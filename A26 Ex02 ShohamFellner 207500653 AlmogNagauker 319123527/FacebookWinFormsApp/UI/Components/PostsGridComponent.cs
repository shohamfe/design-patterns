using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Models;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class PostsGridComponent : UserControl, IPopulatable<PostGridDetails>
    {
        public PostsGridComponent()
        {
            InitializeComponent();
        }

        public void Populate(PostGridDetails i_Data)
        {
            ItemsGrid.SuspendLayout();

            if (i_Data?.Items != null && i_Data.Items.Count > 0)
            {
                labelNoPosts.Visible = false;

                TitleLabel.Text = i_Data.Title;

                foreach (PostDetails postData in i_Data.Items)
                {
                    PostComponent postItemComponent = new PostComponent();

                    ItemsGrid.Controls.Add(postItemComponent);

                    postItemComponent.Populate(postData);
                }
            }
            else
            {
                labelNoPosts.Visible = true;
            }

            ItemsGrid.ResumeLayout();
        }
    }
}
