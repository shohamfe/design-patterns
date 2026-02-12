using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class PostsGridComponent : UserControl, IPopulatable<PostGridDetails>
    {
        public PostsGridComponent()
        {
            InitializeComponent();
        }

        public async void Populate(PostGridDetails i_Data)
        {
            TitleLabel.Text = i_Data?.Title;

            clearPostComponents();

            if (i_Data?.Items != null && i_Data.Items.Count > 0)
            {
                labelNoPosts.Visible = false;

                await loadPostsAsync(i_Data);
            }
            else
            {
                labelNoPosts.Visible = true;
            }
        }

        private void clearPostComponents()
        {
            List<PostComponent> postComponents = ItemsGrid.Controls.OfType<PostComponent>().ToList();

            foreach (PostComponent postComponent in postComponents)
            {
                ItemsGrid.Controls.Remove(postComponent);
                postComponent.Dispose();
            }
        }

        private async Task loadPostsAsync(PostGridDetails i_Data)
        {
            ItemsGrid.SuspendLayout();
            int count = 0;

            if (!IsDisposed)
            {
                try
                {
                    foreach (PostDetails postData in i_Data.Items)
                    {
                        if (IsDisposed)
                        {
                            break;
                        }

                        addPostComponent(postData);

                        count++;
                        if (count % 5 == 0)
                        {
                            ItemsGrid.ResumeLayout();

                            await Task.Delay(10);

                            ItemsGrid.SuspendLayout();
                        }
                    }
                }
                finally
                {
                    ItemsGrid.ResumeLayout();

                    if (Parent != null)
                    {
                        ItemsGrid.Height = Parent.Height;
                    }
                }
            }
        }

        private void addPostComponent(PostDetails i_PostData)
        {
            PostComponent postComponent = new PostComponent();

            ItemsGrid.Controls.Add(postComponent);

            postComponent.Populate(i_PostData);
        }
    }
}
