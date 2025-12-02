using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class BioComponent : UserControl, IPopulatable<BioDetails>
    {
        public BioComponent()
        {
            InitializeComponent();
        }

        public void Populate(BioDetails i_BioDetails)
        {
            if (i_BioDetails != null)
            {
                labelBio.Text = i_BioDetails.GetBioDetailsAsString();

                // TODO: open the link on click
                linkLabelBio.Text = "Link";
                linkLabelBio.Links.Clear();
                linkLabelBio.Links.Add(0, linkLabelBio.Text.Length, i_BioDetails.Link);

                m_FullNameLabel.Text = i_BioDetails.FullName;

                this.Dock = DockStyle.Top;
                this.BringToFront();
            }
        }

        private void m_BioLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openLink();
        }

        private void openLink()
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.facebook.com",
                    UseShellExecute = true
                });
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link.");
            }
        }
    }
}
