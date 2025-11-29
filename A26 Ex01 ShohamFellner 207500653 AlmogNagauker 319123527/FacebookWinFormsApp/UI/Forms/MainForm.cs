using BasicFacebookFeatures.Singletons;
using BasicFacebookFeatures.UI.Components;
using FacebookWrapper;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private LoginComponent m_LoginComponent;
        private ProfilePageComponent m_ProfilePage;

        public MainForm()
        {
            InitializeComponent();
        }

        private void FacebookMainForm_Load(object sender, EventArgs e)
        {
            loadLoginComponent();
        }

        private void m_ProfileButton_Click(object sender, EventArgs e)
        {
            loadProfilePage();
        }

        private void loadAvatar()
        {
            if (FacebookSessionSingleton.Instance.LoginResult != null)
            {
                pictureBoxProfile.ImageLocation = FacebookSessionSingleton.Instance.LoggedInUser.PictureSmallURL;
                m_ProfileName.Text = FacebookSessionSingleton.Instance.LoggedInUser.Name;
                menuPanel.Visible = true;
            }
        }

        private void loadLoginComponent()
        {
            removeAllPages();

            m_LoginComponent = new LoginComponent();

            m_LoginComponent.LoggedInEventHandler += loginComponent_LoggedIn;

            m_LoginComponent.Dock = DockStyle.Fill;
            m_LoginComponent.BringToFront();

            mainPanel.Controls.Add(m_LoginComponent);
        }

        private void loadProfilePage()
        {
            if (FacebookSessionSingleton.Instance.LoginResult != null && !mainPanel.Controls.Contains(m_ProfilePage))
            {
                removeAllPages();

                m_ProfilePage = new ProfilePageComponent();

                m_ProfilePage.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(m_ProfilePage);
            }
        }

        private void loginComponent_LoggedIn(object sender, EventArgs e)
        {
            loadAvatar();

            removeAllPages();

            // TODO: load feed
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            FacebookService.Logout();
            FacebookSessionSingleton.Instance.LoginResult = null;

            removeAllPages();
            loadLoginComponent();
            menuPanel.Visible = false;
        }

        private void removeAllPages()
        {
            foreach (Control control in mainPanel.Controls)
            {
                control.Dispose();
            }

            mainPanel.Controls.Clear();
        }
    }
}
