using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using BasicFacebookFeatures.Logic.Models;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Singletons
{
    public sealed class FacebookSessionSingleton
    {
        private static FacebookSessionSingleton s_Instance = null;
        private static readonly object sr_LockContext = new object();

        private const string k_FeedFilePath = "Resources/mock_friend_feed.json";
        private const string k_CloseFriendsFilePath = "Resources/mock_close_friends.json";

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
                return getListFromFile<PostDetails>(k_FeedFilePath);
            }
        }

        public List<PostDetails> CloseFriendsFeedPosts
        {
            get
            {
                List<PostDetails> feed = new List<PostDetails>();

                List<string> closeFriendsList = getListFromFile<string>(k_CloseFriendsFilePath);

                HashSet<string> closeFriendsSet = new HashSet<string>(closeFriendsList);

                if (closeFriendsList != null && closeFriendsList.Count > 0)
                {
                    foreach (PostDetails post in FeedPosts)
                    {
                        if (closeFriendsSet.Contains(post.FullName))
                        {
                            feed.Add(post);
                        }
                    }
                }

                return feed;
            }
        }

        private List<T> getListFromFile<T>(string i_FilePath)
        {
            List<T> list = null;

            if (File.Exists(i_FilePath))
            {
                string jsonData = File.ReadAllText(i_FilePath);

                try
                {
                    JsonSerializerOptions jsonOptions = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        IncludeFields = true
                    };

                    list = JsonSerializer.Deserialize<List<T>>(jsonData);
                }
                catch
                {
                }
            }

            if (list == null)
            {
                list = new List<T>();
            }

            return list;
        }
    }
}
