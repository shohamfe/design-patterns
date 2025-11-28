using System;
using System.Windows.Forms;
using BasicFacebookFeatures.UI.Components;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        public event EventHandler<FacebookWrapper.LoginResult> UserLoggedInEventHandler;

        private FacebookWrapper.LoginResult m_LoginResult;

        private LoginComponent m_LoginComponent = new LoginComponent();
        private ProfilePage m_ProfilePage;

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
            if (m_LoginResult != null)
            {
                menuPanel.Visible = true;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureSmallURL;
                m_ProfileName.Text = m_LoginResult.LoggedInUser.Name;
            }
        }

        private void loadProfilePage()
        {
            if (m_ProfilePage == null && m_LoginResult != null)
            {
                m_ProfilePage = new ProfilePage(m_LoginResult);
                m_ProfilePage.Dock = DockStyle.Fill;
                this.Controls.Add(m_ProfilePage);
            }

            m_ProfilePage.BringToFront();
        }

        private void loginComponent_LoggedIn(object sender, FacebookWrapper.LoginResult i_LoginResult)
        {
            OnUserLoggedIn();

            m_LoginResult = i_LoginResult;
            loadAvatar();

            this.Controls.Remove(m_LoginComponent);
            m_LoginComponent.Dispose();
        }

        protected virtual void OnUserLoggedIn()
        {
            UserLoggedInEventHandler?.Invoke(this, m_LoginResult);
        }
    }
}
