using BasicFacebookFeatures.Enums;
using BasicFacebookFeatures.Factories;
using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic;
using BasicFacebookFeatures.Logic.Managers;
using BasicFacebookFeatures.Logic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class ProfilePageComponent : UserControl
    {
        private readonly BioComponent r_BioComponent = new BioComponent();
        private readonly TitledGridComponent r_AlbumsGrid = new TitledGridComponent();
        private readonly TitledGridComponent r_FriendsGrid = new TitledGridComponent();
        private readonly TitledGridComponent r_LikedPagesGrid = new TitledGridComponent();
        private readonly PostComponent r_PostComponent = new PostComponent();

        public ProfilePageComponent()
        {
            InitializeComponent();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            showBioComponent();
            showAlbumsGrid();
            showFriendsGrid();
            showLikedPAgesGrid();
            showPostComponent();
        }

        private void showBioComponent()
        {
            BioManager bioManager = new BioManager();

            BioDetails data = bioManager.GetBioDetails();

            r_BioComponent.Populate(data);

            if (r_BioComponent != null && !r_BioComponent.IsDisposed)
            {
                Main.Controls.Add(r_BioComponent);
            }
        }

        private void loadAndShowGrid<T>(eGridItemType i_Type, string i_Title, TitledGridComponent i_GridComponent)
        {
            IGridItemManager<T> manager = GridManagerFactory.CreateManager<T>(i_Type);

            if (manager != null)
            {
                TitledGridGenerator<T> generator = new TitledGridGenerator<T>(manager);
                TitledGridDetails data = generator.GenerateGrid(i_Title);

                i_GridComponent.Populate(data);

                if (!i_GridComponent.IsDisposed)
                {
                    Main.Controls.Add(i_GridComponent);
                }
            }
        }

        private void showAlbumsGrid()
        {
            loadAndShowGrid<Album>(eGridItemType.Albums, "My Albums", r_AlbumsGrid);
        }

        private void showFriendsGrid()
        {
            loadAndShowGrid<User>(eGridItemType.Friends, "My Friends", r_FriendsGrid);
        }

        private void showLikedPAgesGrid()
        {
            loadAndShowGrid<Page>(eGridItemType.LikedPages, "Liked Pages", r_LikedPagesGrid);
        }


        private void showPostComponent()
        {
            PostsGridManager postGridManager = new PostsGridManager();

            PostGridDeatails gridData = postGridManager.GetPostDetails();

            if (gridData != null && gridData.Items != null && gridData.Items.Any())
            {
                foreach (PostDetails postData in gridData.Items)
                {
                    PostComponent newPostComponent = new PostComponent();
                    newPostComponent.Populate(postData);
                    Main.Controls.Add(newPostComponent);
                }
            }
            else
            {
                System.Windows.Forms.Label labelNoPosts = new System.Windows.Forms.Label();
                labelNoPosts.Text = "No Posts to show";
                labelNoPosts.AutoSize = true;
                Main.Controls.Add(labelNoPosts);
            }
        }
    }
}
