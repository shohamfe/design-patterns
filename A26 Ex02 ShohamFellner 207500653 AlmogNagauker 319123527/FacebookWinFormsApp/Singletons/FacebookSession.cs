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
        public event Action<string> CloseFriendsStatusChanged;

        private List<PostDetails> m_FeedPosts;
        private List<PostDetails> m_CloseFriendsPosts;
        private HashSet<string> m_CloseFriendsIdsSet;


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
                if (m_CloseFriendsPosts == null)
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
                if (m_CloseFriendsIdsSet == null)
                {
                    loadCloseFriendsIds();
                }

                return m_CloseFriendsIdsSet;
            }
        }

        private void UpdateCloseFriendsFeedPosts()
        {
            m_CloseFriendsPosts = new List<PostDetails>();

            foreach (PostDetails post in FeedPosts)
            {
                if (CloseFriendsIdSet.Contains(post.UserId))
                {
                    m_CloseFriendsPosts.Add(post);
                }
            }
        }

        public void UpdateCloseFriendState(string i_UserId, bool i_IsCloseFriend)
        {
            if (!i_IsCloseFriend)
            {
                CloseFriendsIdSet.Add(i_UserId);
                UpdateCloseFriendsFeedPosts();
            }
            else
            {
                CloseFriendsIdSet.Remove(i_UserId);
                CloseFriendsFeedPosts.RemoveAll(post => post.UserId == i_UserId);
            }

            CloseFriendsStatusChanged?.Invoke(i_UserId);
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
