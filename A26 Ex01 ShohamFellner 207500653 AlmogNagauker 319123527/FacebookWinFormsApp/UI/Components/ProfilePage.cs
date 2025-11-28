using BasicFacebookFeatures.Logic;
using BasicFacebookFeatures.Logic.Managers;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class ProfilePage : UserControl
    {
        private readonly FacebookWrapper.LoginResult r_LoginResult;


        private readonly BioManager r_BioManager;
        private readonly BioComponent r_BioComponent;

        private readonly AlbumsGridManager r_AlbumGridManager;
        private readonly TitledGridComponent r_AlbumsGrid;

        public ProfilePage(ref FacebookWrapper.LoginResult i_LoginResult)
        {
            InitializeComponent();

            r_LoginResult = i_LoginResult;

            r_BioManager = new BioManager(r_LoginResult);
            r_BioComponent = new BioComponent();

            r_AlbumGridManager = new AlbumsGridManager(r_LoginResult);
            r_AlbumsGrid = new TitledGridComponent();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            loadBioComponent();
            loadAlbums();
        }

        private void loadBioComponent()
        {
            BioDetails data = r_BioManager.GetBioDetails();

            r_BioComponent.Populate(data);
            Main.Controls.Add(r_BioComponent);
        }

        private void loadAlbums()
        {
            r_AlbumsGrid.Populate(r_AlbumGridManager.GetTitledGridDetails<Album>());
            Main.Controls.Add(r_AlbumsGrid);
        }

    }
}
