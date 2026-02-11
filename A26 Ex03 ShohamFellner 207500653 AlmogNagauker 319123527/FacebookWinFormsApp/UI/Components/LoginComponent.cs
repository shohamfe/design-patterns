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
            string errorMessage = string.Empty;

            LabelError.Visible = false;

            try
            {
                bool isLoginSuccess = FacebookSession.Instance.Login(textBoxAppID.Text, out errorMessage);

                if (isLoginSuccess)
                {
                    afterLogin();
                }
                else
                {
                    this.ActiveControl = null;

                    throw new Exception(errorMessage);
                }
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
