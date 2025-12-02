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

                linkLabelBio.Text = "Link";
                linkLabelBio.Links.Clear();
                linkLabelBio.Links.Add(0, linkLabelBio.Text.Length, i_BioDetails.Link);

                labelFullName.Text = i_BioDetails.FullName;

                this.Dock = DockStyle.Top;
                this.BringToFront();
            }
        }

        private void openLink()
        {
            try
            {
                if (linkLabelBio.Links.Count > 0)
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = linkLabelBio.Links[0].LinkData.ToString(),
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link.");
            }
        }

        private void linkLabelBio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openLink();
        }
    }
}
