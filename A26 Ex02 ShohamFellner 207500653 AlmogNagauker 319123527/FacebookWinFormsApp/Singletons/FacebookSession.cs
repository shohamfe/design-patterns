using BasicFacebookFeatures.Logic.Infrastructure;
using BasicFacebookFeatures.Logic.Managers;
using BasicFacebookFeatures.Logic.Models;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows;

namespace BasicFacebookFeatures.Singletons
{
    public sealed class FacebookSession
    {
        private HashSet<string> m_CloseFriendsIdsSet = new HashSet<string>();
        private readonly List<PostDetails> m_CloseFriendsPosts = new List<PostDetails>();

        private List<PostDetails> m_FeedPosts;

        private FacebookSession() { }

        public static FacebookSession Instance
        {
            get
            {
                return Singleton<FacebookSession>.Instance;
            }
        }

        public LoginResult LoginResult { get; set; }

        public User LoggedInUser
        {
            get
            {
                User user = null;

                try
                {
                    user = LoginResult?.LoggedInUser;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Session Error");
                }

                return user;
            }
        }

        public string AccessToken
        {
            get
            {
                return LoginResult?.AccessToken;
            }
        }

        public List<PostDetails> FeedPosts
        {
            get
            {
                if (m_FeedPosts == null)
                {
                    loadFeedPosts();
                }

                return m_FeedPosts;
            }
        }

        public List<PostDetails> CloseFriendsFeedPosts
        {
            get
            {
                if (m_CloseFriendsPosts.Count == 0 && CloseFriendsIdSet.Count > 0)
                {
                    UpdateCloseFriendsFeedPosts();
                }

                return m_CloseFriendsPosts;
            }
        }

        public HashSet<string> CloseFriendsIdSet
        {
            get
            {
                if (m_CloseFriendsIdsSet.Count == 0)
                {
                    loadCloseFriendsIds();
                }

                return m_CloseFriendsIdsSet;
            }
        }

        private void UpdateCloseFriendsFeedPosts()
        {
            foreach (PostDetails post in FeedPosts)
            {
                if (m_CloseFriendsIdsSet.Contains(post.UserId))
                {
                    m_CloseFriendsPosts.Add(post);
                }
            }
        }

        public void UpdateCloseFriendState(string i_UserId, bool i_IsCloseFriend)
        {
            if (!i_IsCloseFriend)
            {
                m_CloseFriendsIdsSet.Add(i_UserId);
                UpdateCloseFriendsFeedPosts();
            }
            else
            {
                m_CloseFriendsIdsSet.Remove(i_UserId);
                CloseFriendsFeedPosts.RemoveAll(post => post.UserId == i_UserId);
            }
        }

        private void loadFeedPosts()
        {
            m_FeedPosts = FileManager.LoadFromFile<List<PostDetails>>(FileManager.k_FeedFilePath);
        }

        private void loadCloseFriendsIds()
        {
            List<string> closeFriendsList = FileManager.LoadFromFile<List<string>>(FileManager.k_CloseFriendsFilePath);

            m_CloseFriendsIdsSet = new HashSet<string>(closeFriendsList);
        }
    }
}
