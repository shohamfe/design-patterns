using BasicFacebookFeatures.Logic.Helpers;
using BasicFacebookFeatures.Logic.Models;
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
        private FeedPageComponent m_FeedPage;
        private CloseFriendsFeedComponent m_CloseFriendsFeedComponent;

        public MainForm()
        {
            InitializeComponent();

            ThemeManager.Instance.ThemeChanged += applyThemeToAll;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            loadLoginComponent();

            applyThemeToAll(ThemeManager.Instance.CurrentTheme);
        }

        private void m_ProfileButton_Click(object sender, EventArgs e)
        {
            loadProfilePage();
        }

        private void applyThemeToAll(AppTheme i_AppTheme)
        {
            ThemeColorizer.ApplyTheme(this, i_AppTheme);
        }

        private void loadAvatar()
        {
            try
            {
                if (FacebookSessionSingleton.Instance.LoginResult != null)
                {
                    pictureBoxProfile.ImageLocation = FacebookSessionSingleton.Instance.LoggedInUser.PictureSmallURL;
                    labelUserName.Text = FacebookSessionSingleton.Instance.LoggedInUser.Name;
                    menuPanel.Visible = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!");
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
            try
            {
                if (FacebookSessionSingleton.Instance.LoginResult != null && !mainPanel.Controls.Contains(m_ProfilePage))
                {
                    removeAllPages();

                    m_ProfilePage = new ProfilePageComponent();

                    m_ProfilePage.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(m_ProfilePage);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!");
            }
        }

        private void loginComponent_LoggedIn(object sender, EventArgs e)
        {
            loadAvatar();

            removeAllPages();

            LoadFeedPage();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                FacebookService.Logout();
                FacebookSessionSingleton.Instance.LoginResult = null;

                removeAllPages();
                loadLoginComponent();
                menuPanel.Visible = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!");
            }
        }

        private void removeAllPages()
        {
            foreach (Control control in mainPanel.Controls)
            {
                control.Dispose();
            }

            mainPanel.Controls.Clear();
        }

        private void LoadFeedPage()
        {
            removeAllPages();

            m_FeedPage = new FeedPageComponent();
            m_FeedPage.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(m_FeedPage);
        }

        private void CLoseFriendsFeedButton_Click(object sender, EventArgs e)
        {
            loadCloseFriendsFeedPage();
        }

        private void loadCloseFriendsFeedPage()
        {
            removeAllPages();

            m_CloseFriendsFeedComponent = new CloseFriendsFeedComponent();
            m_CloseFriendsFeedComponent.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(m_CloseFriendsFeedComponent);
        }

        private void m_FeedButton_Click(object sender, EventArgs e)
        {
            LoadFeedPage();
        }
    }
}
