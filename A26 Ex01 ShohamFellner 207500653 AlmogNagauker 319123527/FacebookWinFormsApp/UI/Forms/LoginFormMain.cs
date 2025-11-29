using BasicFacebookFeatures.Singletons;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BasicFacebookFeatures
{
    public partial class LoginFormMain : Form
    {
        public event EventHandler<FacebookWrapper.LoginResult> LoggedInEventHandler;


        public LoginFormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
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
                FacebookSessionSingleton.Instance.LoginResult = FacebookService.Connect("EAAQykGq3ihQBQJaUlWOxUY3vZBCtrhByhmiuFASP5YGoAFb8AVWCiKRS1fQ9ZCY3VrXAyqzAlOPFYx1g8SQhZCUJrkwc7wzydudC5xGMZAgANVwod8so42VCL4RcZAo3ZCbq1dRu1jngkO0PqXWyPnukTkulT66jExiFV9gQZBUp5wK1EHYQ8u34GejxsuTNVPpvlZANsg5n4hfPrQCnzMdm69W1CA6bEAelRtWom9iUrmeLNHiQCTQfa3wPZCoufZBJMm1xrpzFvLrtaoOgZDZD");

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
            buttonLogin.Text = $"Logged in as {FacebookSessionSingleton.Instance.LoginResult.LoggedInUser.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            pictureBoxProfile.ImageLocation = FacebookSessionSingleton.Instance.LoginResult.LoggedInUser.PictureNormalURL;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;

            OnLoggedIn();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            FacebookSessionSingleton.Instance.LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        protected virtual void OnLoggedIn()
        {
            LoggedInEventHandler?.Invoke(this, FacebookSessionSingleton.Instance.LoginResult);
        }
    }
}
