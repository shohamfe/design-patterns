using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic.Managers;
using BasicFacebookFeatures.Logic.Models;

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
            FeedManager feedManager = new FeedManager("Resources/mock_friend_feed.json");
            List<PostDetails> friendPosts = feedManager.LoadFeedFromFile();

            CloseFriendManager closeFriendManager = new CloseFriendManager("Resources/close_friends.json");
            HashSet<string> closeFriendsSet = closeFriendManager.LoadCloseFriendsFromFile();

            List<PostDetails> closeFriendsPosts = friendPosts
                .Where(post => closeFriendsSet.Contains(post.FullName))
                .ToList();

            postsPanel.Controls.Clear();
            PostGridDetails friendsGridData = new PostGridDetails("Close Friends Feed", closeFriendsPosts);

            if (m_PostsGridComponent == null || m_PostsGridComponent.IsDisposed)
            {

                m_PostsGridComponent = new PostsGridComponent();
            }

            m_PostsGridComponent.Populate(friendsGridData);

            m_PostsGridComponent.Dock = DockStyle.Fill;
            postsPanel.Controls.Add(m_PostsGridComponent);
        }
    }
}
