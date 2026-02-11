using BasicFacebookFeatures.Logic.Helpers;
using BasicFacebookFeatures.Logic.Managers;
using BasicFacebookFeatures.Logic.Models;
using BasicFacebookFeatures.Singletons;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class CloseFriendsFeedComponent : UserControl
    {
        private PostsGridComponent m_PostsGridComponent;

        public CloseFriendsFeedComponent()
        {
            InitializeComponent();
        }

        private void CloseFriendFeed_Load(object sender, EventArgs e)
        {
            PostsGridManager postGridManager = new PostsGridManager();

            List<PostDetails> posts = FacebookSession.Instance.User.CloseFriendsFeedPosts;
            PostGridDetails postsGridData = new PostGridDetails("Close Friends Feed", posts);

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
