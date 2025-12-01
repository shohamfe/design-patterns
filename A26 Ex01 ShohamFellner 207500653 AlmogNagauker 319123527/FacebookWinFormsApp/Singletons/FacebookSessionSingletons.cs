using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
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
        private const string k_CloseFriendsFilePath = "Resources/close_friends.json";

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

        public FacebookObjectCollection<Post> FeedPosts
        {
            get
            {
                getFeedPosts<PostDetails>(k_FeedFilePath);
                return new FacebookObjectCollection<Post>();
            }
        }

        public FacebookObjectCollection<Post> CloseFriendsFeedPosts
        {
            get
            {
                FacebookObjectCollection<Post> feed = new FacebookObjectCollection<Post>();

                FacebookObjectCollection<User> closeFriendsList= getFeedPosts<User>(k_CloseFriendsFilePath);

                HashSet<string> closeFriendsSet = new HashSet<string>();

                if (closeFriendsList != null)
                {
                    foreach (User closeFriend in closeFriendsList)
                    {
                        closeFriendsSet.Add(closeFriend.Name);
                    }

                    foreach(Post post in FeedPosts)
                    {
                        if (closeFriendsSet.Contains(post.Name))
                        {
                            feed.Add(post);
                        }
                    }
                }

                return feed;
            }
        }

        private FacebookObjectCollection<T> getFeedPosts<T>(string i_FilePath)
        {
                FacebookObjectCollection<T> list= null;

                if (File.Exists(i_FilePath))
                {
                    string jsonData = File.ReadAllText(i_FilePath);

                    try
                    {
                        // var test = JsonConvert.DeserializeObject<FeedRootDetails>(jsonData);
                        var test = JsonConvert.DeserializeObject<FeedRootDetails>(jsonData);


                    //list = JsonSerializer.Deserialize<FacebookObjectCollection<T>>(jsonData);
                }
                catch
                    {
                    }
                }
                
                if(list == null)
                {
                    list = new FacebookObjectCollection<T>();
                }

                return list;
        }

        
    }
}
