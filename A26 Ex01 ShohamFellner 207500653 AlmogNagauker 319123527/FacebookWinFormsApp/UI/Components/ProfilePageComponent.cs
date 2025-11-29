using BasicFacebookFeatures.Enums;
using BasicFacebookFeatures.Factories;
using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic;
using BasicFacebookFeatures.Logic.Managers;
using BasicFacebookFeatures.Logic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class ProfilePageComponent : UserControl
    {
        private BioComponent m_BioComponent;
        private TitledGridComponent m_AlbumsGrid;
        private TitledGridComponent m_FriendsGrid;
        private TitledGridComponent m_LikedPagesGrid;
        private PostComponent m_PostComponent = new PostComponent();

        public ProfilePageComponent()
        {
            InitializeComponent();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            showBioComponent();
            showFriendsGrid();
            showAlbumsGrid();
            showLikedPAgesGrid();
            showPostComponent();
        }

        private void showBioComponent()
        {
            BioManager bioManager = new BioManager();

            BioDetails data = bioManager.GetBioDetails();


            if (m_BioComponent == null || m_BioComponent.IsDisposed)
            {
                m_BioComponent = new BioComponent();
            }

            m_BioComponent.Populate(data);
            Main.Controls.Add(m_BioComponent);
        }

        private void loadAndShowGrid<T>(eGridItemType i_Type, string i_Title, ref TitledGridComponent i_GridComponent)
        {
            IGridItemManager<T> manager = GridManagerFactory.CreateManager<T>(i_Type);

            if (manager != null)
            {
                TitledGridGenerator<T> generator = new TitledGridGenerator<T>(manager);
                TitledGridDetails data = generator.GenerateGrid(i_Title);

                if (i_GridComponent == null || i_GridComponent.IsDisposed)
                {
                    i_GridComponent = new TitledGridComponent();
                }

                Main.Controls.Add(i_GridComponent);
                i_GridComponent.Populate(data);
            }
        }

        private void showAlbumsGrid()
        {
            loadAndShowGrid<Album>(eGridItemType.Albums, "My Albums", ref m_AlbumsGrid);
        }

        private void showFriendsGrid()
        {
            loadAndShowGrid<User>(eGridItemType.Friends, "My Friends", ref m_FriendsGrid);
        }

        private void showLikedPAgesGrid()
        {
            loadAndShowGrid<Page>(eGridItemType.LikedPages, "Liked Pages", ref m_LikedPagesGrid);
        }


        private void showPostComponent()
        {
            PostsGridManager postGridManager = new PostsGridManager();

            PostGridDeatails gridData = postGridManager.GetPostDetails();

            if (gridData != null && gridData.Items != null)
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
                Label labelNoPosts = new Label();
                labelNoPosts.Text = "No Posts to show";
                labelNoPosts.AutoSize = true;
                Main.Controls.Add(labelNoPosts);
            }
        }
    }
}
