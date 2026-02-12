using BasicFacebookFeatures.Enums;
using BasicFacebookFeatures.Logic.Helpers;
using BasicFacebookFeatures.Logic.Models;
using BasicFacebookFeatures.Singletons;
using BasicFacebookFeatures.UI.Components;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private readonly LoginComponent r_LoginComponent = new LoginComponent();
        private ProfilePageComponent m_ProfilePage;
        private FeedPageComponent m_FeedPage;
        private CloseFriendsFeedComponent m_CloseFriendsFeedComponent;


        private readonly List<UserControl> r_Controls;

        public MainForm()
        {
            InitializeComponent();

            ThemeManager.Instance.ThemeChanged += applyThemeToAll;

            r_Controls = new List<UserControl> { r_LoginComponent };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            loadComponent(r_LoginComponent);

            initComponents();

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

        private void initComponents()
        {
            r_LoginComponent.LoggedInEventHandler += loginComponent_LoggedIn;
            mainPanel.Controls.Add(r_LoginComponent);
        }

        private void loadAvatar()
        {
            try
            {
                if (FacebookSession.Instance.LoginResult != null)
                {
                    if (string.IsNullOrEmpty(pictureBoxProfile.ImageLocation))
                    {
                        pictureBoxProfile.ImageLocation = FacebookSession.Instance.User.PictureSmallURL;
                        labelUserName.Text = FacebookSession.Instance.User.Name;
                    }

                    setMenuItemsVisibility(true);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!");
            }
        }

        private void hideAllPages()
        {
            foreach (UserControl control in r_Controls)
            {
                control.Visible = false;
            }
        }

        private void loadComponent(UserControl i_Component)
        {
            SuspendLayout();

            try
            {
                if (FacebookSession.Instance.LoginResult != null)
                {
                    hideAllPages();

                    if (i_Component != null && !i_Component.IsDisposed)
                    {
                        i_Component.Visible = true;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!");
            }

            ResumeLayout();
        }

        private void setMenuItemsVisibility(bool i_Visible)
        {
            buttonFeed.Visible = i_Visible;
            buttonProfile.Visible = i_Visible;
            buttonCloseFriends.Visible = i_Visible;
            buttonLogout.Visible = i_Visible;
            panelProfileName.Visible = i_Visible;
        }

        private void loginComponent_LoggedIn(object sender, EventArgs e)
        {
            SuspendLayout();

            loadAvatar();

            loadComponent(m_FeedPage);

            m_ProfilePage = new ProfilePageComponent();
            m_FeedPage = new FeedPageComponent();
            m_CloseFriendsFeedComponent = new CloseFriendsFeedComponent();

            m_ProfilePage.Dock = DockStyle.Fill;
            m_ProfilePage.Visible = false;
            mainPanel.Controls.Add(m_ProfilePage);

            m_FeedPage.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(m_FeedPage);

            m_CloseFriendsFeedComponent.Dock = DockStyle.Fill;
            m_CloseFriendsFeedComponent.Visible = false;
            mainPanel.Controls.Add(m_CloseFriendsFeedComponent);

            r_Controls.Add(m_ProfilePage);
            r_Controls.Add(m_FeedPage);
            r_Controls.Add(m_CloseFriendsFeedComponent);

            ResumeLayout();
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            loadComponent(m_FeedPage);
        }

        private void buttonCloseFriends_Click(object sender, EventArgs e)
        {
            loadComponent(m_CloseFriendsFeedComponent);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            loadComponent(m_ProfilePage);
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
                FacebookSession.Instance.Logout();

                loadComponent(r_LoginComponent);
                setMenuItemsVisibility(false);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!");
            }
        }
    }
}
