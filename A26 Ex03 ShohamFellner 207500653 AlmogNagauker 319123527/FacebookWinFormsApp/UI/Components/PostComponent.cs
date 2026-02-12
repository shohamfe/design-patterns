using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Managers;
using BasicFacebookFeatures.Logic.Models;
using BasicFacebookFeatures.Singletons;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class PostComponent : UserControl, IPopulatable<PostDetails>
    {
        private PostDetails m_PostDetails;

        public PostComponent()
        {
            InitializeComponent();
        }

        public void Populate(PostDetails i_Details)
        {
            SuspendLayout();

            if (i_Details != null)
            {
                m_PostDetails = i_Details;
                postDetailsBindingSource.DataSource = m_PostDetails;
            }

            fitSizes();

            ResumeLayout();
        }

        private void fitSizes()
        {
            this.Dock = DockStyle.Top;

            if (this.Parent != null)
            {
                this.Width = this.Parent.ClientSize.Width - 10;
            }

            int maxCardWidth = this.Width - Card.Margin.Horizontal;
            Card.MaximumSize = new Size(maxCardWidth, 0);

            int maxLabelWidth = Card.MaximumSize.Width - PostText.Margin.Horizontal;
            PostText.MaximumSize = new Size(maxLabelWidth, 0);
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            m_PostDetails.PostLikes++;

            MessageBox.Show(@"Feature unavailable due to library restrictions.
Please Like this post in your heart ❤️", "Like");
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            m_PostDetails.PostComments++;

            MessageBox.Show(@"Library restrictions prevent actual commenting.
Please transmit your thoughts telepathically", "Comment");
        }

        private void toggleStarState()
        {
            try
            {
                FileManager.SaveToFile(FacebookSession.Instance.User.CloseFriendsIdSet.ToList(), FileManager.k_CloseFriendsFilePath);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
            }

            FacebookSession.Instance.User.UpdateCloseFriendState(m_PostDetails.UserId, m_PostDetails.IsCloseFriends);
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            toggleStarState();
        }
    }
}
