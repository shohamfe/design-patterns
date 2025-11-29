using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Models;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class PostComponent : UserControl, IPopulatable<PostDetails>
    {
        public PostComponent()
        {
            InitializeComponent();
        }

        public void Populate(PostDetails i_Details)
        {
            if (i_Details != null)
            {
                postAuthorProfilePicture.ImageLocation = i_Details.ImageURL;
                PostAuthorName.Text = i_Details.FullName;
                PostDate.Text = i_Details.PostTime;
                PostText.Text = i_Details.PostText;
                CountOfLike.Text = $"{i_Details.PostLikes.ToString()} likes";
                CountOfComments.Text = $"{i_Details.PostComments.ToString()} comments";
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
    }
}
