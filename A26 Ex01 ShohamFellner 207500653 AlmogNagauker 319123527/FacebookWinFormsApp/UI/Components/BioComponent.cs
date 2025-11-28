using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class BioComponent : UserControl, IPopulateable<BioDetails>
    {


        public BioComponent()
        {
            InitializeComponent();
        }

        public void Populate(BioDetails i_BioDetails)
        {
            if (i_BioDetails != null)
            {
                m_BioLabel.Text = i_BioDetails.GetBioDetailsAsString();

                // TODO: open the link on click
                m_BioLinkLabel.Text = "Link";
                m_BioLinkLabel.Links.Clear();
                m_BioLinkLabel.Links.Add(0, m_BioLinkLabel.Text.Length, i_BioDetails.Link);

                m_FullNameLabel.Text = i_BioDetails.FullName;

                this.Dock = DockStyle.Top;
                this.BringToFront();
            }
        }
    }
}
