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
    public partial class ProfilePage : UserControl
    {
        private readonly BioManager m_BioManager;
        private BioComponent m_BioComponent;

        public ProfilePage(ref FacebookWrapper.LoginResult i_LoginResult)
        {
            InitializeComponent();

            m_BioManager = new BioManager(i_LoginResult);
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            loadBioComponent();
        }

        private void loadBioComponent()
        {
            BioDetails data = m_BioManager.GetBioDetails();

            m_BioComponent = new BioComponent();

            m_BioComponent.Populate(data);

            this.Controls.Add(m_BioComponent);
        }
    }
}
