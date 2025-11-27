using BasicFacebookFeatures.Logic;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class ProfilePage : UserControl
    {
        private readonly BioManager m_BioManager;
        private readonly BioComponent m_BioComponent;
        private readonly AlbumsGridComponent m_AlbumsGrid;

        public ProfilePage(ref FacebookWrapper.LoginResult i_LoginResult)
        {
            InitializeComponent();

            m_BioManager = new BioManager(i_LoginResult);
            m_AlbumsGrid = new AlbumsGridComponent(i_LoginResult.LoggedInUser.Albums);

            m_BioComponent = new BioComponent();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            loadBioComponent();
            loadAlbums();
        }

        private void loadBioComponent()
        {
            BioDetails data = m_BioManager.GetBioDetails();

            m_BioComponent.Populate(data);
            Main.Controls.Add(m_BioComponent);
        }

        private void loadAlbums()
        {
            Main.Controls.Add(m_AlbumsGrid);
        }

    }
}
