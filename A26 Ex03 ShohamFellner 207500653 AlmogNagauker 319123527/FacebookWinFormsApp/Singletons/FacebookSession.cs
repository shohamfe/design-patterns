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

            // TODO: replace connect with comment
            //Almog's token for testing
            //FacebookSession.Instance.LoginResult = FacebookService.Connect("EAAQykGq3ihQBQGP2CFT3Ls7PDH3kr5IwdqFTCUHPtJqNVzNSUf3QPHCfP645D8SbdIs0e67HZBaDphXNmMpfcWpDZAncLC7mmZCxa6lyFXRNPZBhjfypQHI617zad400CeTTngBjTTJZBoXU6dW6lgZCgSf5nJSQaRyjFkSp5hDqmyuipfjb0BbRogAUgI0vNSRuMv2XPDDsjTmyx3HfIC75Di8onf5w8RqDXz2VdCdXoBRRYemOZCYoBgKc3Dc");

            //Shoham's token for testing
            //FacebookSession.Instance.LoginResult = FacebookService.Connect("EAAQykGq3ihQBQKLioVB0PCZBpsTzyZB15gfZC0ZBZBqPLZCptFjto3knsBvQ2jqwMFq3dazMOD3KCg5gJO45xSsIPstea2UzGi8YzM7i63dwNH4FB51mw7dHAP1aZChjSQ2QGcGk0VqJcCFZA8QarjoTXGm2zyNvR4InOha6mLikTUCXbfbRA9nVDLZAZBShjJMnzCYVqg8l8NMmK9aflDEdeBPsFslOYhS5zdg6cPHmvNPHWG0lQw8WCEj5EQZArZCbRVu8x8Et46IdCOIUuwZDZD");

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
