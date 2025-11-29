using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class PostComponent : UserControl, IPopulatable<PostDetails>
    {
        public event EventHandler likeRequest;

        private PostDetails m_PostDetails;

        private int m_NumOfLikes = 0;
        private int m_NumOfComments = 0;

        public PostComponent()
        {
            InitializeComponent();
        }

        public void Populate(PostDetails i_Details)
        {
            if (i_Details != null)
            {
                m_PostDetails = i_Details;

                m_NumOfLikes = m_PostDetails.PostLikes;
                m_NumOfComments = m_PostDetails.PostComments;

                postAuthorProfilePicture.ImageLocation = m_PostDetails.ImageURL;
                PostAuthorName.Text = m_PostDetails.FullName;
                PostDate.Text = m_PostDetails.PostTime;
                PostText.Text = m_PostDetails.PostText;

                setLikeLabelText();
                setCommentLabelText();
            }

            fitSizes();
        }

        private void fitSizes()
        {
            this.Dock = DockStyle.Top;

            int maxCardWidth = this.Parent.Width - Card.Margin.Horizontal;
            Card.MaximumSize = new Size(maxCardWidth, 0);

            int maxLabelWidth = Card.MaximumSize.Width - PostText.Margin.Horizontal;
            PostText.MaximumSize = new Size(maxLabelWidth, 0);
        }

        private void setLikeLabelText()
        {
            CountOfLike.Text = $"{m_NumOfLikes} likes";
        }

        private void setCommentLabelText()
        {
            CountOfComments.Text = $"{m_NumOfComments} comments";
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            m_NumOfLikes++;
            setLikeLabelText();

            MessageBox.Show(@"Feature unavailable due to library restrictions.
Please Like this post in your heart ❤️", "Like");

        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            m_NumOfComments++;
            setCommentLabelText();

            MessageBox.Show(@"Library restrictions prevent actual commenting.
Please transmit your thoughts telepathically", "Comment");
        }
    }
}
