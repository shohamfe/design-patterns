using System;
using System.Threading;
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

        private void FeedPageComponent_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(fetchFeedData);
            thread.IsBackground = true;
            thread.Start();
        }

        private void fetchFeedData()
        {
            List<PostDetails> posts = FacebookSession.Instance.User.FeedPosts;
            PostGridDetails postsGridData = new PostGridDetails("Feed", posts);

            try
            {

                if (!this.IsDisposed)
                {
                    this.BeginInvoke(new Action(() => FeedPage_Load(postsGridData)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading feed: {ex.Message}", "Error");
            }
        }

        private void FeedPage_Load(PostGridDetails i_PostsGridData)
        {
            this.SuspendLayout();

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
                this.ResumeLayout();
            }
        }
    }
}
