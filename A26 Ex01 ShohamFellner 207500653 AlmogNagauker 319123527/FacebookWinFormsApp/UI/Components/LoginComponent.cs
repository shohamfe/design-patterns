using FacebookWrapper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class LoginComponent : UserControl
    {
        private FacebookWrapper.LoginResult m_LoginResult;

        public event EventHandler<FacebookWrapper.LoginResult> LoggedInEventHandler;

        public LoginComponent()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");


            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            try
            {

                m_LoginResult = FacebookService.Login(
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


                if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
                {
                    afterLogin();
                }


            ////TODO: replace connect with comment
            //    m_LoginResult = FacebookService.Connect("EAAQykGq3ihQBQJaUlWOxUY3vZBCtrhByhmiuFASP5YGoAFb8AVWCiKRS1fQ9ZCY3VrXAyqzAlOPFYx1g8SQhZCUJrkwc7wzydudC5xGMZAgANVwod8so42VCL4RcZAo3ZCbq1dRu1jngkO0PqXWyPnukTkulT66jExiFV9gQZBUp5wK1EHYQ8u34GejxsuTNVPpvlZANsg5n4hfPrQCnzMdm69W1CA6bEAelRtWom9iUrmeLNHiQCTQfa3wPZCoufZBJMm1xrpzFvLrtaoOgZDZD");

            //    afterLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(m_LoginResult?.ErrorMessage, "Login Failed");
            }
        }


        private void buttonConnectAsDesig_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoginResult = FacebookService.Connect("EAAUm6cZC4eUEBPZCFs9rJRpwlUmdHcPvU1tUNkIyP37zRZCjSvfdHaW5t3xsOnUL0bEKHL8Snjk6AZC3O32KWEbaItglEnXWQ2zEMXHqsdfdv0ecXNs3hO69juHrZCfRN9FGvfuJZAXhP4Pm57DRRoDeB8De6ZABnfrRflh6zgPwnavpyHS3ZCYX1E6K1QLTHff5sAZDZD");

                afterLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void afterLogin()
        {
            OnLoggedIn();
        }

        protected virtual void OnLoggedIn()
        {
            LoggedInEventHandler?.Invoke(this, m_LoginResult);
        }
    }
}
