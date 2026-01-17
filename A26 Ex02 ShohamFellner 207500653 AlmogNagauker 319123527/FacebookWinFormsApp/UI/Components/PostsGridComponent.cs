using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Models;
using System;
using System.Threading;
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
            TitleLabel.Text = i_Data?.Title;

            if (i_Data?.Items != null && i_Data.Items.Count > 0)
            {
                labelNoPosts.Visible = false;

                Thread loaderThread = new Thread(() => loadPostsThread(i_Data));
                loaderThread.IsBackground = true;
                loaderThread.Start();
            }
            else
            {
                labelNoPosts.Visible = true;
            }
        }

        private void loadPostsThread(PostGridDetails i_Data)
        {
            foreach (PostDetails postData in i_Data.Items)
            {
                if (!IsDisposed)
                {
                    Invoke(new Action(() => addPostComponent(postData)));
                }

                Thread.Sleep(20);
            }
        }

        private void addPostComponent(PostDetails i_PostData)
        {
            PostComponent postItemComponent = new PostComponent();

            ItemsGrid.Controls.Add(postItemComponent);

            postItemComponent.Populate(i_PostData);
        }
    }
}
