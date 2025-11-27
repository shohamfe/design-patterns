using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic;
using BasicFacebookFeatures.UI.Components;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FacebookMainForm : Form
    {
        private FacebookWrapper.LoginResult m_LoginResult;

        private ProfilePage m_ProfilePage;

        public FacebookMainForm(ref FacebookWrapper.LoginResult i_LoginResult)
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
                Main.Controls.Add(m_ProfilePage);
            }

            m_ProfilePage.BringToFront();
        }
    }
}
