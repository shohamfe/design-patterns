using System;
using System.Windows.Forms;
using BasicFacebookFeatures.UI.Components;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private FacebookWrapper.LoginResult m_LoginResult;

        private ProfilePage m_ProfilePage;

        public MainForm(ref FacebookWrapper.LoginResult i_LoginResult)
        {
            InitializeComponent();

            m_LoginResult = i_LoginResult;
        }

        private void FacebookMainForm_Load(object sender, EventArgs e)
        {
            loadAvatar();
        }

        private void m_ProfileButton_Click(object sender, EventArgs e)
        {
            loadProfilePage();
        }

        private void loadAvatar()
        {
            pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureSmallURL;
            m_ProfileName.Text = m_LoginResult.LoggedInUser.Name;
        }

        private void loadProfilePage()
        {
            if (m_ProfilePage == null)
            {
                m_ProfilePage = new ProfilePage(ref m_LoginResult);
                m_ProfilePage.Dock = DockStyle.Fill;
                this.Controls.Add(m_ProfilePage);
            }

            m_ProfilePage.BringToFront();
        }
    }
}
