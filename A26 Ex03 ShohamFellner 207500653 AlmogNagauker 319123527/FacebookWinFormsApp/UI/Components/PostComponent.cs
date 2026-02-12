using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Command;
using BasicFacebookFeatures.Logic.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class PostComponent : UserControl, IPopulatable<PostDetails>
    {
        private PostDetails m_PostDetails;
        private LikePostCommand m_LikePostCommand;
        private CommentPostCommand m_CommentPostCommand;
        private CloseFriendCommand m_CloseFriendCommand;

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

                m_LikePostCommand = new LikePostCommand(m_PostDetails);
                m_CommentPostCommand = new CommentPostCommand(m_PostDetails);
                m_CloseFriendCommand = new CloseFriendCommand(m_PostDetails);
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
            m_LikePostCommand.Execute();
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            m_CommentPostCommand.Execute();
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            m_CloseFriendCommand.Execute();
        }
    }
}
