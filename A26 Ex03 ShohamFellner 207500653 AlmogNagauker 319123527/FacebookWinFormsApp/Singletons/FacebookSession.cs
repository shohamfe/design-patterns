using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Infrastructure;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows;

namespace BasicFacebookFeatures.Singletons
{
    public sealed partial class FacebookSession
    {
        private User m_LoggedInUser;
        private readonly CachedUser r_CachedUser = new CachedUser();

        private FacebookSession() { }

        public static FacebookSession Instance
        {
            get
            {
                return Singleton<FacebookSession>.Instance;
            }
        }

        public LoginResult LoginResult { get; set; }

        public IUser User
        {
            get
            {
                if (m_LoggedInUser == null || r_CachedUser.User == null)
                {
                    try
                    {
                        m_LoggedInUser = LoginResult?.LoggedInUser;
                        r_CachedUser.User = m_LoggedInUser;
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message, "Session Error");
                    }
                }

                return r_CachedUser;
            }
        }

        public event Action<string> CloseFriendsStatusChanged
        {
            add
            {
                ((CachedUser)User).CloseFriendsStatusChanged += value;
            }
            remove
            {
                ((CachedUser)User).CloseFriendsStatusChanged -= value;
            }
        }

        public bool Login(string i_AppId, out string o_ErrorMessage)
        {
            bool isLoginSuccess = true;
            o_ErrorMessage = string.Empty;

            FacebookSession.Instance.LoginResult = FacebookService.Login(
                i_AppId,
                /// requested permissions:
                "email",
                "user_birthday",
                "user_gender",
                "public_profile",
                "user_friends",
                "user_photos",
                "user_posts",
                "user_videos",
                "user_likes",
                "user_link"
                /// add any relevant permissions
                );


            if (!string.IsNullOrEmpty(LoginResult.ErrorMessage) || User == null)
            {
                isLoginSuccess = false;

                if (User == null)
                {
                    o_ErrorMessage = "Failed to retrieve user data.";
                }
                else
                {
                    o_ErrorMessage = LoginResult.ErrorMessage;
                }

                LoginResult = null;
            }

            return isLoginSuccess;
        }

        public void Logout()
        {
            FacebookService.Logout();
            LoginResult = null;
            m_LoggedInUser = null;
            r_CachedUser.ClearCache();
            r_CachedUser.User = null;
        }
    }
}
