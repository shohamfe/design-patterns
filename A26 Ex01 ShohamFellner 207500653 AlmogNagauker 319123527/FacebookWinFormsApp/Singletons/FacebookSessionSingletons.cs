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

        public static FacebookSessionSingleton Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockContext)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FacebookSessionSingleton();
                        }
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
                return FileManager.GetListFromFile<PostDetails>(FileManager.k_FeedFilePath);
            }
        }

        public List<PostDetails> CloseFriendsFeedPosts
        {
            get
            {
                if (m_CloseFriendsPosts.Count == 0 && CloseFriendsIdSet.Count > 0)
                {
                    foreach (PostDetails post in FeedPosts)
                    {
                        if (m_CloseFriendsIdsSet.Contains(post.UserId))
                        {
                            m_CloseFriendsPosts.Add(post);
                        }
                    }
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
                    List<string> closeFriendsList = FileManager.GetListFromFile<string>(FileManager.k_CloseFriendsFilePath);

                    m_CloseFriendsIdsSet = new HashSet<string>(closeFriendsList);
                }

                return m_CloseFriendsIdsSet;
            }
        }
    }
}
