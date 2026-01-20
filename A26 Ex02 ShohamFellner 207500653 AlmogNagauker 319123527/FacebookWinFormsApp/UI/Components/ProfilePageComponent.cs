using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.Enums;
using BasicFacebookFeatures.Factories;
using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic;
using BasicFacebookFeatures.Logic.Helpers;
using BasicFacebookFeatures.Logic.Managers;
using BasicFacebookFeatures.Logic.Models;
using BasicFacebookFeatures.Singletons;
using FacebookWrapper.ObjectModel;

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
            new Thread(fetchProfileData).Start();
        }

        private void fetchProfileData()
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

            this.BeginInvoke(new Action(() => populateBioComponent(data)));
        }

        private void populateBioComponent(BioDetails i_Data)
        {
            if (m_BioComponent == null || m_BioComponent.IsDisposed)
            {
                m_BioComponent = new BioComponent();
            }

            m_BioComponent.Populate(i_Data);
            ThemeColorizer.ApplyTheme(m_BioComponent, ThemeManager.Instance.CurrentTheme);

            profilePanel.Controls.Add(m_BioComponent);
        }

        private void loadAndShowGrid<T>(eGridItemType i_Type, string i_Title, ref TitledGridComponent i_GridComponent)
        {
            IGridItemManager<T> manager = GridManagerFactory.Create<T>(i_Type);

            if (manager != null)
            {
                TitledGridGenerator<T> generator = new TitledGridGenerator<T>(manager);
                TitledGridDetails data = generator.GenerateGrid(i_Title);

                TitledGridComponent localComponent = i_GridComponent;
                this.BeginInvoke(new Action(() => localComponent = updateAndGetGridUI(localComponent, data)));
            }
        }

        private TitledGridComponent updateAndGetGridUI(TitledGridComponent i_GridComponent, TitledGridDetails i_Data)
        {
            if (i_GridComponent == null || i_GridComponent.IsDisposed)
            {
                i_GridComponent = new TitledGridComponent();
            }

            i_GridComponent.Populate(i_Data);
            ThemeColorizer.ApplyTheme(i_GridComponent, ThemeManager.Instance.CurrentTheme);

            if (!i_GridComponent.IsDisposed)
            {
                profilePanel.Controls.Add(i_GridComponent);
            }
            return i_GridComponent;
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

            FacebookObjectCollection<Post> posts = FacebookSession.Instance.User.Posts;
            PostGridDetails postsGridData = postGridManager.GetPostDetails("My Posts", posts);

            this.BeginInvoke(new Action(() => populatePostsComponent(postsGridData)));
        }

        private void populatePostsComponent(PostGridDetails i_PostsGridData)
        {
            if (m_PostsGridComponent == null || m_PostsGridComponent.IsDisposed)
            {
                m_PostsGridComponent = new PostsGridComponent();
            }

            m_PostsGridComponent.Populate(i_PostsGridData);
            ThemeColorizer.ApplyTheme(m_PostsGridComponent, ThemeManager.Instance.CurrentTheme);

            postsPanel.Controls.Add(m_PostsGridComponent);
        }
    }
}
