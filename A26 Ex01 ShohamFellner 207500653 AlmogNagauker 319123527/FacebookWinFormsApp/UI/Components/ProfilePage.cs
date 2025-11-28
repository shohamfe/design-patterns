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
        private readonly BioComponent r_BioComponent = new BioComponent();

        private readonly AlbumsGridManager r_AlbumGridManager;
        private readonly TitledGridComponent r_AlbumsGrid = new TitledGridComponent();

        private readonly FriendsGridManager r_FriendsGridManager;
        private readonly TitledGridComponent r_FriendsGrid = new TitledGridComponent();

        public ProfilePage(ref FacebookWrapper.LoginResult i_LoginResult)
        {
            InitializeComponent();

            r_LoginResult = i_LoginResult;

            r_BioManager = new BioManager(r_LoginResult);

            r_AlbumGridManager = new AlbumsGridManager(r_LoginResult);

            r_FriendsGridManager = new FriendsGridManager(r_LoginResult);
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            loadBioComponent();
            loadAlbumsGrid();
            loadFriendsGrid();
        }

        private void loadBioComponent()
        {
            BioDetails data = r_BioManager.GetBioDetails();

            r_BioComponent.Populate(data);

            if (r_BioComponent != null && !r_BioComponent.IsDisposed)
            {
                Main.Controls.Add(r_BioComponent);
            }
        }

        private void loadAlbumsGrid()
        {
            r_AlbumsGrid.Populate(r_AlbumGridManager.GetTitledGridDetails<Album>());

            if (r_AlbumsGrid != null && !r_AlbumsGrid.IsDisposed)
            {
                Main.Controls.Add(r_AlbumsGrid);
            }
        }

        private void loadFriendsGrid()
        {
            r_FriendsGrid.Populate(r_FriendsGridManager.GetTitledGridDetails<User>());

            if (r_FriendsGrid != null && !r_FriendsGrid.IsDisposed)
            {
                Main.Controls.Add(r_FriendsGrid);
            }
        }

    }
}
