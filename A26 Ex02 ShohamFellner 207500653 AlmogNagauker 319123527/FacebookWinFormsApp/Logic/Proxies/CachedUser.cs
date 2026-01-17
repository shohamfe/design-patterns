using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Managers;
using BasicFacebookFeatures.Logic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using static FacebookWrapper.ObjectModel.User;

namespace BasicFacebookFeatures.Singletons
{
    public sealed partial class FacebookSession
    {
        public class CachedUser : IUser
        {
            internal event Action<string> CloseFriendsStatusChanged;

            private User m_User;

            private FacebookObjectCollection<User> m_FriendsCache;
            private FacebookObjectCollection<Album> m_AlbumsCache;
            private FacebookObjectCollection<Page> m_LikedPagesCache;
            private FacebookObjectCollection<Post> m_PostsCache;
            private string m_NameCache;
            private string m_FirstNameCache;
            private string m_LastNameCache;
            private string m_MiddleNameCache;
            private string m_LinkCache;
            private eGender? m_GenderCache;
            private string BirthdayCache;
            private string m_EmailCache;
            private eRelationshipStatus? m_RelationshipStatusCache;
            private City m_HometownCache;
            private Page[] m_LanguagesCache;
            private List<PostDetails> m_FeedPosts;
            private List<PostDetails> m_CloseFriendsPosts;
            private HashSet<string> m_CloseFriendsIdsSet;

            internal CachedUser() { }

            public User User
            {
                get
                {
                    return m_User;
                }
                internal set
                {
                    m_User = value;
                }
            }

            public FacebookObjectCollection<User> Friends
            {
                get
                {
                    return retrieveCachedData(ref m_FriendsCache, () => m_User.Friends);
                }
            }

            public FacebookObjectCollection<Album> Albums
            {
                get
                {
                    return retrieveCachedData(ref m_AlbumsCache, () => m_User.Albums);
                }
            }

            public FacebookObjectCollection<Page> LikedPages
            {
                get
                {
                    return retrieveCachedData(ref m_LikedPagesCache, () => m_User.LikedPages);
                }
            }

            public FacebookObjectCollection<Post> Posts
            {
                get
                {
                    return retrieveCachedData(ref m_PostsCache, () => m_User.Posts);
                }
            }

            public string Name
            {
                get
                {
                    return retrieveCachedData(ref m_NameCache, () => m_User.Name);
                }
            }

            public string FirstName
            {
                get
                {
                    return retrieveCachedData(ref m_FirstNameCache, () => m_User.FirstName);
                }
            }

            public string LastName
            {
                get
                {
                    return retrieveCachedData(ref m_LastNameCache, () => m_User.LastName);
                }
            }

            public string MiddleName
            {
                get
                {
                    return retrieveCachedData(ref m_MiddleNameCache, () => m_User.MiddleName);
                }
            }

            public string Link
            {
                get
                {
                    return retrieveCachedData(ref m_LinkCache, () => m_User.Link);
                }
            }

            public eGender Gender
            {
                get
                {
                    return retrieveCachedValue(ref m_GenderCache, () => (eGender)m_User.Gender);
                }
            }

            public string Birthday
            {
                get
                {
                    return retrieveCachedData(ref BirthdayCache, () => m_User.Birthday);
                }
            }

            public string Email
            {
                get
                {
                    return retrieveCachedData(ref m_EmailCache, () => m_User.Email);
                }
            }
            public eRelationshipStatus RelationshipStatus
            {
                get
                {
                    return retrieveCachedValue(ref m_RelationshipStatusCache, () => (eRelationshipStatus)m_User.RelationshipStatus);
                }
            }

            public City Hometown
            {
                get
                {
                    return retrieveCachedData(ref m_HometownCache, () => m_User.Hometown);
                }
            }

            public Page[] Languages
            {
                get
                {
                    return retrieveCachedData(ref m_LanguagesCache, () => m_User.Languages);
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

            public string PictureSmallURL { get { return m_User.PictureSmallURL; } }

            public string PictureNormalURL { get { return m_User.PictureNormalURL; } }

            public string PictureLargeURL { get { return m_User.PictureLargeURL; } }

            public string PictureSquareURL { get { return m_User.PictureSqaureURL; } }

            public string Id { get { return m_User.Id; } }

            private T retrieveCachedData<T>(ref T io_CacheField, Func<T> i_LoadingMethod) where T : class
            {
                if (io_CacheField == null)
                {
                    io_CacheField = i_LoadingMethod.Invoke();
                }

                return io_CacheField;
            }

            private T retrieveCachedValue<T>(ref T? io_CacheField, Func<T> i_LoadingMethod) where T : struct
            {
                if (!io_CacheField.HasValue)
                {
                    io_CacheField = i_LoadingMethod.Invoke();
                }

                return io_CacheField.Value;
            }

            public void ClearCache()
            {
                m_FriendsCache = null;
                m_AlbumsCache = null;
                m_LikedPagesCache = null;
                m_PostsCache = null;
            }
        }

    }
}
