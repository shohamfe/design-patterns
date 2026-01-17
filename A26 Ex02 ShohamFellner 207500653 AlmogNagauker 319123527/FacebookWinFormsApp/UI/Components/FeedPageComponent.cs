using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic.Helpers;
using BasicFacebookFeatures.Logic.Models;
using BasicFacebookFeatures.Singletons;
using System.Collections.Generic;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class FeedPageComponent : UserControl
    {
        private bool m_IsLoading = false;
        private List<PostDetails> m_AllPosts;
        private int m_currentIndex = 0;
        private const int k_batchSize = 10;
        private PostsGridComponent m_PostsGridComponent;

        public FeedPageComponent()
        {
            InitializeComponent();
            this.Main.Scroll += (s, e) => checkAndLoadMore();
            this.Main.MouseWheel += (s, e) => checkAndLoadMore();
        }

        private void checkAndLoadMore()
        {
            if (m_IsLoading)
            {
                return;
            }
            int scrollPosition = Main.VerticalScroll.Value + Main.Height;
            int totalHeight = postsPanel.Height;

            if (scrollPosition >= totalHeight - 100)
            {
                new Thread(loadNextBatch).Start();
            }
        }

        private void FeedPageComponent_Load(object sender, EventArgs e)
        {
            new Thread(fetchFeedData).Start();
        }

        private void fetchFeedData()
        {
            m_AllPosts = FacebookSession.Instance.FeedPosts;
            m_currentIndex = 0;
            loadNextBatch();
        }

        private void loadNextBatch()
        {
            if (m_AllPosts == null || m_currentIndex >= m_AllPosts.Count)
            {
                return;
            }

            m_IsLoading = true;
            int end = Math.Min(m_currentIndex + k_batchSize, m_AllPosts.Count);

            for (int i = m_currentIndex; i < end; i++)
            {
                PostDetails currentPost = m_AllPosts[i];
                this.Invoke(new Action(() => addSinglePostToUI(currentPost)));
                m_currentIndex++;
                Thread.Sleep(5);
            }

            m_IsLoading = false;
        }

        private void addSinglePostToUI(PostDetails i_Post)
        {
            if (m_currentIndex == 0)
            {
                postsPanel.Controls.Clear();
            }

            List<PostDetails> singlePostList = new List<PostDetails> { i_Post };
            PostGridDetails singleData = new PostGridDetails("Feed", singlePostList);

            PostsGridComponent postGrid = new PostsGridComponent();
            postGrid.Populate(singleData);
            ThemeColorizer.ApplyTheme(postGrid, ThemeManager.Instance.CurrentTheme);

            postsPanel.AutoSize = true;
            postsPanel.Controls.Add(postGrid);
        }



        //private void FeedPage_Load(PostGridDetails i_PostsGridData)
        //{
        //    this.SuspendLayout();
        //    postsPanel.SuspendLayout();

        //    try
        //    {
        //        if (m_PostsGridComponent == null || m_PostsGridComponent.IsDisposed)
        //        {
        //            m_PostsGridComponent = new PostsGridComponent();
        //        }

        //        m_PostsGridComponent.Populate(i_PostsGridData);
        //        ThemeColorizer.ApplyTheme(m_PostsGridComponent, ThemeManager.Instance.CurrentTheme);

        //        m_PostsGridComponent.Dock = DockStyle.Fill;
        //        postsPanel.Controls.Clear();
        //        postsPanel.Controls.Add(m_PostsGridComponent);
        //    }

        //    finally
        //    {
        //        postsPanel.ResumeLayout();
        //        this.ResumeLayout();
        //    }
        //}
    }
}

