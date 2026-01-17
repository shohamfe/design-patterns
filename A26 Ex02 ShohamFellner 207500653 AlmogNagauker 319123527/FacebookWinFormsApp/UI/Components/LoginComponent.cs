using BasicFacebookFeatures.Singletons;
using FacebookWrapper;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class LoginComponent : UserControl
    {
        public event EventHandler LoggedInEventHandler;

        public LoginComponent()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");


            if (FacebookSession.Instance.LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            LabelError.Visible = false;

            try
            {
                FacebookSession.Instance.LoginResult = FacebookService.Login(
                    textBoxAppID.Text,
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


                if (FacebookSession.Instance.LoginResult.LoggedInUser != null && string.IsNullOrEmpty(FacebookSession.Instance.LoginResult.ErrorMessage))
                {
                    afterLogin();
                }
                else
                {
                    this.ActiveControl = null;
                    FacebookSession.Instance.LoginResult = null;

                }


                // TODO: replace connect with comment
                //Almog's token for testing
                //FacebookSession.Instance.LoginResult = FacebookService.Connect("EAAQykGq3ihQBQGP2CFT3Ls7PDH3kr5IwdqFTCUHPtJqNVzNSUf3QPHCfP645D8SbdIs0e67HZBaDphXNmMpfcWpDZAncLC7mmZCxa6lyFXRNPZBhjfypQHI617zad400CeTTngBjTTJZBoXU6dW6lgZCgSf5nJSQaRyjFkSp5hDqmyuipfjb0BbRogAUgI0vNSRuMv2XPDDsjTmyx3HfIC75Di8onf5w8RqDXz2VdCdXoBRRYemOZCYoBgKc3Dc");

                //Shoham's token for testing
                //FacebookSession.Instance.LoginResult = FacebookService.Connect("EAAQykGq3ihQBQKLioVB0PCZBpsTzyZB15gfZC0ZBZBqPLZCptFjto3knsBvQ2jqwMFq3dazMOD3KCg5gJO45xSsIPstea2UzGi8YzM7i63dwNH4FB51mw7dHAP1aZChjSQ2QGcGk0VqJcCFZA8QarjoTXGm2zyNvR4InOha6mLikTUCXbfbRA9nVDLZAZBShjJMnzCYVqg8l8NMmK9aflDEdeBPsFslOYhS5zdg6cPHmvNPHWG0lQw8WCEj5EQZArZCbRVu8x8Et46IdCOIUuwZDZD");

                //afterLogin();
            }
            catch (Exception ex)
            {
                showErrorLabel(ex);
            }
        }


        private void buttonConnectAsDesig_Click(object sender, EventArgs e)
        {
            LabelError.Visible = false;

            try
            {
                FacebookSession.Instance.LoginResult = FacebookService.Connect("EAAUm6cZC4eUEBQTAa3rRgO39UZCIJLeD9OpF5SYAevqSaFI16sfjT6JznpAUbyX5Soyj4Uv2ZBRkesoHO9omNcJ3KSYPZCExgaKrIprACUMIVnhiHzT5a46zbdC2VkvZC04n1ZARj8WmvOCYyuIdmRZBNjtWZCFJrbjFoms5t3sU8G9dO1xDCYH7kkfU67heIUZCFDIuTtL0CzF2JUHBpRpwPdXYilOJW811z3C5fY9TOyBiUwZAqx4ZAV6YS5ZBBtYKdsb7");

                afterLogin();
            }
            catch (Exception ex)
            {
                showErrorLabel(ex);
            }
        }

        private void showErrorLabel(Exception ex)
        {
            LabelError.Text = $"Login Failed: {ex.Message}";
            LabelError.Visible = true;
        }

        private void afterLogin()
        {
            OnLoggedIn();
        }

        protected virtual void OnLoggedIn()
        {
            LoggedInEventHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}
