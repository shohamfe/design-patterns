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
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FacebookMainForm : Form
    {
        private FacebookWrapper.LoginResult m_LoginResult;
        private BioManager m_BioManager;

        public FacebookMainForm(ref FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
            m_BioManager = new BioManager(i_LoginResult);
            InitializeComponent();

        }

        private void FacebookMain_Load(object sender, EventArgs e)
        {
            pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureLargeURL;
        }

        private void GetFacebookLogoMain_Load(object sender, EventArgs e)
        {
            FacebookLogo.ImageLocation = "https://share.google/images/zf534aJDySMSCwJzH";
            FacebookLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void m_AdditionalInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void m_ProfileButton_Click(object sender, EventArgs e)
        {
            m_BioComponent.ShowBio(m_BioManager.GetBioDetails());
            //showBio();
        }

        //private void showBio()
        //{
        //    BioDetails bioDetails = m_BioManager.GetBioDetails();

        //    m_BioLabel.Text = bioDetails.GetBioDetailsAsString();

        //    // TODO: open the link on click
        //    m_BioLinkLabel.Text = "Link";
        //    m_BioLinkLabel.Links.Clear();
        //    m_BioLinkLabel.Links.Add(0, m_BioLinkLabel.Text.Length, bioDetails.Link);

        //    m_FullNameLabel.Text = bioDetails.FullName;

        //    m_BioPanel.Show();
        //}

        private void m_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void m_BioLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
