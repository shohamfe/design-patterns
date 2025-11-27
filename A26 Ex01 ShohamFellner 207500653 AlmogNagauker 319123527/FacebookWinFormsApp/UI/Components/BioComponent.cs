using BasicFacebookFeatures.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class BioComponent : UserControl
    {
        public BioComponent()
        {
            InitializeComponent();
        }

        public void Populate(BioDetails i_BioDetails)
        {
            m_BioLabel.Text = i_BioDetails.GetBioDetailsAsString();

            // TODO: open the link on click
            m_BioLinkLabel.Text = "Link";
            m_BioLinkLabel.Links.Clear();
            m_BioLinkLabel.Links.Add(0, m_BioLinkLabel.Text.Length, i_BioDetails.Link);

            m_FullNameLabel.Text = i_BioDetails.FullName;
        }
    }
}
