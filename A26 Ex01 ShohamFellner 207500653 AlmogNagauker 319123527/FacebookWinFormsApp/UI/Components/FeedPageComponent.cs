using BasicFacebookFeatures.Logic.Helpers;
using BasicFacebookFeatures.Logic.Models;
using BasicFacebookFeatures.Singletons;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class FeedPageComponent : UserControl
    {
        private PostsGridComponent m_PostsGridComponent;
        public FeedPageComponent()
        {
            InitializeComponent();
        }

        private void FeedPage_Load(object sender, EventArgs e)
        { 
            List<PostDetails> posts = FacebookSession.Instance.FeedPosts;
            PostGridDetails postsGridData = new PostGridDetails("Feed", posts);

            postsPanel.Controls.Clear();

            if (m_PostsGridComponent == null || m_PostsGridComponent.IsDisposed)
            {
                m_PostsGridComponent = new PostsGridComponent();
            }

            m_PostsGridComponent.Populate(postsGridData);
            ThemeColorizer.ApplyTheme(m_PostsGridComponent, ThemeManager.Instance.CurrentTheme);

            m_PostsGridComponent.Dock = DockStyle.Fill;
            postsPanel.Controls.Add(m_PostsGridComponent);
        }
    }
}
