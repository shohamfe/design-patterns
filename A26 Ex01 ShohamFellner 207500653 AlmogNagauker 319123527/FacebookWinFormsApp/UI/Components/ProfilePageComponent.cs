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
        private PostsGridComponent m_PostsGridComponent;

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
            showPostsComponent();
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
            profilePanel.Controls.Add(m_BioComponent);
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

                profilePanel.Controls.Add(i_GridComponent);
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

        private void showPostsComponent()
        {
            PostsGridManager postGridManager = new PostsGridManager();

            PostGridDetails postsGridData = postGridManager.GetPostDetails();

            if (m_PostsGridComponent == null || m_PostsGridComponent.IsDisposed)
            {
                m_PostsGridComponent = new PostsGridComponent();
            }

            m_PostsGridComponent.Populate(postsGridData);
            postsPanel.Controls.Add(m_PostsGridComponent);
        }
    }
}
