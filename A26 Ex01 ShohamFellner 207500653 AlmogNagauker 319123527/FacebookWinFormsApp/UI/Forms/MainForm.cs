using BasicFacebookFeatures.Enums;
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

            initThemeComboBox();

            applyThemeToAll(ThemeManager.Instance.CurrentTheme);
        }

        private void applyThemeToAll(AppTheme i_AppTheme)
        {
            ThemeColorizer.ApplyTheme(this, i_AppTheme);
        }

        private void initThemeComboBox()
        {
            comboBoxTheme.DataSource = Enum.GetValues(typeof(eThemeType));

            comboBoxTheme.SelectedItem = ThemeManager.Instance.CurrentTheme.GetType();
        }

        private void loadAvatar()
        {
            try
            {
                if (FacebookSession.Instance.LoginResult != null)
                {
                    pictureBoxProfile.ImageLocation = FacebookSession.Instance.LoggedInUser.PictureSmallURL;
                    labelUserName.Text = FacebookSession.Instance.LoggedInUser.Name;
                    setMenuItemsVisibility(true);
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

            ThemeColorizer.ApplyTheme(m_LoginComponent, ThemeManager.Instance.CurrentTheme);

            mainPanel.Controls.Add(m_LoginComponent);
        }

        private void loadProfilePage()
        {
            try
            {
                if (FacebookSession.Instance.LoginResult != null && !mainPanel.Controls.Contains(m_ProfilePage))
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

        private void loadCloseFriendsFeedPage()
        {
            removeAllPages();

            m_CloseFriendsFeedComponent = new CloseFriendsFeedComponent();
            m_CloseFriendsFeedComponent.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(m_CloseFriendsFeedComponent);
        }

        private void setMenuItemsVisibility(bool i_Visible)
        {
            buttonFeed.Visible = i_Visible;
            buttonProfile.Visible = i_Visible;
            buttonCloseFriends.Visible = i_Visible;
            buttonLogout.Visible = i_Visible;
            panelProfileName.Visible = i_Visible;
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            LoadFeedPage();
        }

        private void buttonCloseFriends_Click(object sender, EventArgs e)
        {
            loadCloseFriendsFeedPage();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            loadProfilePage();
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTheme.SelectedItem is eThemeType selectedTheme)
            {
                ThemeManager.Instance.SetTheme(selectedTheme);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                FacebookService.Logout();
                FacebookSession.Instance.LoginResult = null;

                removeAllPages();
                loadLoginComponent();
                setMenuItemsVisibility(false);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!");
            }
        }
    }
}
