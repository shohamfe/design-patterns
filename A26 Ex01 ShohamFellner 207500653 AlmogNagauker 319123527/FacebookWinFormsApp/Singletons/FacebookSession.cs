using System.Collections.Generic;
using BasicFacebookFeatures.Logic.Managers;
using BasicFacebookFeatures.Logic.Models;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Singletons
{
    public sealed class FacebookSessionSingleton
    {
        private static FacebookSessionSingleton s_Instance = null;
        private static readonly object sr_LockContext = new object();

        private HashSet<string> m_CloseFriendsIdsSet = new HashSet<string>();
        private readonly List<PostDetails> m_CloseFriendsPosts = new List<PostDetails>();

        private List<PostDetails> m_FeedPosts;

        private FacebookSessionSingleton() { }

        public static FacebookSessionSingleton Instance
        {
            get
            {
                lock (sr_LockContext)
                {
                    if (s_Instance == null)
                    {
                        s_Instance = new FacebookSessionSingleton();
                    }
                }

                return s_Instance;
            }
        }

        public LoginResult LoginResult { get; set; }

        public User LoggedInUser
        {
            get
            {
                return LoginResult?.LoggedInUser;
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

        public void UpdateCloseFriendsFeedPosts()
        {
            foreach (PostDetails post in FeedPosts)
            {
                if (m_CloseFriendsIdsSet.Contains(post.UserId))
                {
                    m_CloseFriendsPosts.Add(post);
                }
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
