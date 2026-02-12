using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic.Helpers;
using BasicFacebookFeatures.Logic.Models;
using BasicFacebookFeatures.Singletons;
using System.Collections.Generic;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class FeedPageComponent : UserControl
    {
        private PostsGridComponent m_PostsGridComponent;

        public FeedPageComponent()
        {
            InitializeComponent();
        }

        private async void FeedPageComponent_Load(object sender, EventArgs e)
        {
            await fetchFeedDataAsync();
        }

        private async Task fetchFeedDataAsync()
        {
            try
            {
                // Run data fetching on background thread
                PostGridDetails postsGridData = await Task.Run(() =>
                {
                    List<PostDetails> posts = FacebookSession.Instance.User.FeedPosts;
                    return new PostGridDetails("Feed", posts);
                });

                // Update UI on UI thread (automatically after await)
                if (!this.IsDisposed)
                {
                    FeedPage_Load(postsGridData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading feed: {ex.Message}", "Error");
            }
        }

        private void FeedPage_Load(PostGridDetails i_PostsGridData)
        {
            SuspendLayout();

            try
            {
                if (m_PostsGridComponent == null || m_PostsGridComponent.IsDisposed)
                {
                    m_PostsGridComponent = new PostsGridComponent();
                    postsPanel.Controls.Add(m_PostsGridComponent);
                    m_PostsGridComponent.Populate(i_PostsGridData);
                    m_PostsGridComponent.Dock = DockStyle.Fill;
                }

                ThemeColorizer.ApplyTheme(m_PostsGridComponent, ThemeManager.Instance.CurrentTheme);
            }
            finally
            {
                ResumeLayout();
            }
        }
    }
}