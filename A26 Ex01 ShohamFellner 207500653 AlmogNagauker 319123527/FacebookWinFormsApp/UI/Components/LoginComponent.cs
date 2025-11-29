using BasicFacebookFeatures.Singletons;
using FacebookWrapper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class LoginComponent : UserControl
    {
        public event EventHandler<LoginResult> LoggedInEventHandler;

        public LoginComponent()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");


            if (FacebookSessionSingleton.Instance.LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            try
            {

                //LoginResult = FacebookService.Login(
                //    textBoxAppID.Text,
                //    /// requested permissions:
                //    "email",
                //    "user_birthday",
                //    "user_gender",
                //    "public_profile",
                //    "user_friends",
                //    "user_photos",
                //    "user_posts",
                //    "user_videos",
                //    "user_likes",
                //    "user_link"
                //    /// add any relevant permissions
                //    );


                //if (string.IsNullOrEmpty(LoginResult.ErrorMessage))
                //{
                //    afterLogin();
                //}


                // TODO: replace connect with comment
                FacebookSessionSingleton.Instance.LoginResult = FacebookService.Connect("EAAQykGq3ihQBQGP2CFT3Ls7PDH3kr5IwdqFTCUHPtJqNVzNSUf3QPHCfP645D8SbdIs0e67HZBaDphXNmMpfcWpDZAncLC7mmZCxa6lyFXRNPZBhjfypQHI617zad400CeTTngBjTTJZBoXU6dW6lgZCgSf5nJSQaRyjFkSp5hDqmyuipfjb0BbRogAUgI0vNSRuMv2XPDDsjTmyx3HfIC75Di8onf5w8RqDXz2VdCdXoBRRYemOZCYoBgKc3Dc");

                afterLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(FacebookSessionSingleton.Instance.LoginResult?.ErrorMessage, "Login Failed");
            }
        }


        private void buttonConnectAsDesig_Click(object sender, EventArgs e)
        {
            try
            {
                FacebookSessionSingleton.Instance.LoginResult = FacebookService.Connect("EAAUm6cZC4eUEBPZCFs9rJRpwlUmdHcPvU1tUNkIyP37zRZCjSvfdHaW5t3xsOnUL0bEKHL8Snjk6AZC3O32KWEbaItglEnXWQ2zEMXHqsdfdv0ecXNs3hO69juHrZCfRN9FGvfuJZAXhP4Pm57DRRoDeB8De6ZABnfrRflh6zgPwnavpyHS3ZCYX1E6K1QLTHff5sAZDZD");

                afterLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(FacebookSessionSingleton.Instance.LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void afterLogin()
        {
            OnLoggedIn();
        }

        protected virtual void OnLoggedIn()
        {
            LoggedInEventHandler?.Invoke(this, FacebookSessionSingleton.Instance.LoginResult);
        }
    }
}
