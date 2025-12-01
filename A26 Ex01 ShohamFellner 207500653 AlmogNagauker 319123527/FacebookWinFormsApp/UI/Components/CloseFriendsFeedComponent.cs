using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic.Managers;
using BasicFacebookFeatures.Logic.Models;
using BasicFacebookFeatures.Singletons;
using FacebookWrapper.ObjectModel;

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

            FacebookObjectCollection<Post> posts = FacebookSessionSingleton.Instance.CloseFriendsFeedPosts;
            PostGridDetails postsGridData = postGridManager.GetPostDetails(posts);

            if (m_PostsGridComponent == null || m_PostsGridComponent.IsDisposed)
            {

                m_PostsGridComponent = new PostsGridComponent();
            }

            m_PostsGridComponent.Populate(postsGridData);

            m_PostsGridComponent.Dock = DockStyle.Fill;
            postsPanel.Controls.Add(m_PostsGridComponent);
        }
    }
}
