using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic;
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

                PostAuthorName.Text = m_PostDetails.FullName;
                PostText.Text = m_PostDetails.PostText;

                buttonCloseFriends.Visible = !m_PostDetails.IsLoggedInUser;
                buttonCloseFriends.ImageIndex = m_PostDetails.IsCloseFriends ? 1 : 0;
                buttonCloseFriends.Text = getStarButtonLabel();

                populatePostTime(m_PostDetails.PostTime);
                populateProfilePicture(m_PostDetails.ImageURL);

                setLikeLabelText();
                setCommentLabelText();
            }

            fitSizes();
        }

        private void populateProfilePicture(string i_ImageUrl)
        {
            if (!string.IsNullOrEmpty(i_ImageUrl))
            {
                // is from URL
                if (i_ImageUrl.StartsWith("http"))
                {
                    postAuthorProfilePicture.ImageLocation = i_ImageUrl;
                }
                // is Local File
                else
                {
                    string baseFolder = AppDomain.CurrentDomain.BaseDirectory;
                    string fullPath = Path.Combine(baseFolder, i_ImageUrl);

                    if (File.Exists(fullPath))
                    {
                        postAuthorProfilePicture.ImageLocation = fullPath;
                    }
                }
            }
        }

        private void populatePostTime(string i_PostTime)
        {
            if (!string.IsNullOrEmpty(m_PostDetails.PostTime))
            {
                DateTime parsedDate;
                string original = m_PostDetails.PostTime;

                if (DateTime.TryParse(original, out parsedDate))
                {
                    PostDate.Text = parsedDate.ToString("HH:mm dd/MM/yy");

                }
                else
                {
                    PostDate.Text = original;
                }
            }
            else
            {
                PostDate.Text = string.Empty;
            }
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

        private string getStarButtonLabel()
        {
            return m_PostDetails.IsCloseFriends ? "Remove Close Friend" : "Save to Close Friends";
        }

        private void toggleStarState()
        {
            if (!m_PostDetails.IsCloseFriends)
            {
                FacebookSessionSingleton.Instance.CloseFriendsIdSet.Add(m_PostDetails.UserId);
                FacebookSessionSingleton.Instance.UpdateCloseFriendsFeedPosts();
            }
            else
            {
                FacebookSessionSingleton.Instance.CloseFriendsIdSet.Remove(m_PostDetails.UserId);
                FacebookSessionSingleton.Instance.CloseFriendsFeedPosts.RemoveAll(post => post.UserId == m_PostDetails.UserId);
            }

            buttonCloseFriends.ImageIndex = m_PostDetails.IsCloseFriends ? 1 : 0;
            buttonCloseFriends.Text = getStarButtonLabel();

            try
            {
                FileManager.SaveToFile(FacebookSessionSingleton.Instance.CloseFriendsIdSet.ToList(), FileManager.k_CloseFriendsFilePath);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
            }
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            toggleStarState();
        }
    }
}
