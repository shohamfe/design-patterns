using BasicFacebookFeatures.Singletons;
using BasicFacebookFeatures.UI.Components;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        public event EventHandler<FacebookWrapper.LoginResult> UserLoggedInEventHandler;

        private LoginComponent m_LoginComponent = new LoginComponent();
        private ProfilePageComponent m_ProfilePage;

        public MainForm()
        {
            InitializeComponent();

            m_LoginComponent.LoggedInEventHandler += loginComponent_LoggedIn;
        }

        private void FacebookMainForm_Load(object sender, EventArgs e)
        {
            loadLoginComponent();

        }

        private void m_ProfileButton_Click(object sender, EventArgs e)
        {
            loadProfilePage();
        }

        private void loadLoginComponent()
        {
            m_LoginComponent.Dock = DockStyle.Fill;
            this.Controls.Add(m_LoginComponent);

            m_LoginComponent.BringToFront();
        }

        private void loadAvatar()
        {
            if (FacebookSessionSingleton.Instance.LoginResult != null)
            {
                menuPanel.Visible = true;
                pictureBoxProfile.ImageLocation = FacebookSessionSingleton.Instance.LoggedInUser.PictureSmallURL;
                m_ProfileName.Text = FacebookSessionSingleton.Instance.LoggedInUser.Name;
            }
        }

        private void loadProfilePage()
        {
            if (m_ProfilePage == null && FacebookSessionSingleton.Instance.LoginResult != null)
            {
                m_ProfilePage = new ProfilePageComponent();
                m_ProfilePage.Dock = DockStyle.Fill;
                this.Controls.Add(m_ProfilePage);
            }

            m_ProfilePage.BringToFront();
        }

        private void loginComponent_LoggedIn(object sender, FacebookWrapper.LoginResult i_LoginResult)
        {
            OnUserLoggedIn();

            FacebookSessionSingleton.Instance.LoginResult = i_LoginResult;
            loadAvatar();

            this.Controls.Remove(m_LoginComponent);
            m_LoginComponent.Dispose();
        }

        protected virtual void OnUserLoggedIn()
        {
            UserLoggedInEventHandler?.Invoke(this, FacebookSessionSingleton.Instance.LoginResult);
        }
    }
}
