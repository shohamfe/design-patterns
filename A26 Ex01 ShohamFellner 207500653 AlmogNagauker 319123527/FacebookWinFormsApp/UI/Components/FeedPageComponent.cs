using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic.Managers;
using BasicFacebookFeatures.Logic.Models;

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
            FeedManager feedManager = new FeedManager("Resources/mock_friend_feed.json");
            List<PostDetails> friendPosts = feedManager.LoadFeedFromFile();

            postsPanel.Controls.Clear();
            PostGridDetails friendsGridData = new PostGridDetails("Feed", friendPosts);

            if (m_PostsGridComponent == null || m_PostsGridComponent.IsDisposed)
            {
                m_PostsGridComponent = new PostsGridComponent();
            }

            m_PostsGridComponent.Populate(friendsGridData);

            m_PostsGridComponent.Dock = DockStyle.Fill;
            postsPanel.Controls.Add(m_PostsGridComponent);
        }

        private void CloseFriendFeed_Click(object sender, System.EventArgs e)
        {
            //TO DO: feature - load close friends post 
        }
    }
}
