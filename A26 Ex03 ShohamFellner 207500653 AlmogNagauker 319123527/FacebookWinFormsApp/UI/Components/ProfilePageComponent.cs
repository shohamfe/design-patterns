using System;
using System.Threading.Tasks;
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

        private async void ProfilePage_Load(object sender, EventArgs e)
        {
            await fetchProfileDataAsync();
        }

        private async Task fetchProfileDataAsync()
        {
            await Task.WhenAll(showBioComponentAsync(),
             showFriendsGridAsync(),
             showAlbumsGridAsync(),
             showLikedPAgesGridAsync(),
             showPostsComponentAsync());
        }

        private async Task showBioComponentAsync()
        {
            BioDetails data = await Task.Run(() => new BioManager().GetBioDetails());

            populateBioComponent(data);
        }

        private async void populateBioComponent(BioDetails i_Data)
        {
            if (m_BioComponent == null || m_BioComponent.IsDisposed)
            {
                m_BioComponent = new BioComponent();
            }

            m_BioComponent.Populate(i_Data);
            ThemeColorizer.ApplyTheme(m_BioComponent, ThemeManager.Instance.CurrentTheme);

            profilePanel.Controls.Add(m_BioComponent);
        }

        private async Task<TitledGridComponent> loadAndShowGridAsync<T>(eGridItemType i_Type, string i_Title, TitledGridComponent i_GridComponent)
        {
            var data = await Task.Run(() =>
            {
                IGridItemManager<T> manager = GridManagerFactory.Create<T>(i_Type);
                TitledGridDetails result = null;
                if (manager != null)
                {
                    TitledGridGenerator<T> generator = new TitledGridGenerator<T>(manager);
                    result = generator.GenerateGrid(i_Title);
                }
                return result;
            });

            if (data != null)
            {
                updateAndGetGridUI(i_GridComponent, data);
            }

            return i_GridComponent;
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


        private async Task showAlbumsGridAsync()
        {
            m_AlbumsGrid = await loadAndShowGridAsync<Album>(eGridItemType.Albums, "My Albums", m_AlbumsGrid);
        }

        private async Task showFriendsGridAsync()
        {
            m_FriendsGrid = await loadAndShowGridAsync<User>(eGridItemType.Friends, "My Friends", m_FriendsGrid);
        }

        private async Task showLikedPAgesGridAsync()
        {
            m_LikedPagesGrid = await loadAndShowGridAsync<Page>(eGridItemType.LikedPages, "Liked Pages", m_LikedPagesGrid);
        }

        private async Task showPostsComponentAsync()
        {
            PostGridDetails postsGridData = await Task.Run(() =>
                new PostsGridManager().GetPostDetails("My Posts", FacebookSession.Instance.User.Posts));

            populatePostsComponent(postsGridData);
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
