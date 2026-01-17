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

        public void Logout()
        {
            FacebookService.Logout();
            LoginResult = null;
            m_LoggedInUser = null;
            r_CachedUser.User = null;
        }
    }
}
