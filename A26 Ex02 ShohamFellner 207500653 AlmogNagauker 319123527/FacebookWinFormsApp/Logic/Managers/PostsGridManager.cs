using BasicFacebookFeatures.Logic.Models;
using BasicFacebookFeatures.Singletons;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures.Logic.Managers
{
    public class PostsGridManager
    {
        public PostGridDetails GetPostDetails(string i_Title, FacebookObjectCollection<Post> i_Posts)
        {
            List<PostDetails> postDetailsList = new List<PostDetails>();

            if (i_Posts != null)
            {
                HashSet<string> savedPostsId = getSavedPostsIds();

                foreach (Post post in i_Posts)
                {
                    if (!string.IsNullOrEmpty(post.Message))
                    {
                        PostDetails postDetails = new PostDetails();

                        postDetails.RawData = post;
                        postDetails.FullName = post.Name ?? FacebookSession.Instance.User.Name;
                        postDetails.ImageURL = post.IconURL ?? FacebookSession.Instance.User.PictureSmallURL;
                        postDetails.PostTime = post.CreatedTime.Value.ToString();
                        postDetails.PostText = post.Message;
                        postDetails.PictureURL = post.PictureURL;
                        postDetails.PostId = post.Id;

                        postDetailsList.Add(postDetails);
                    }
                }
            }

            return new PostGridDetails(i_Title, postDetailsList);
        }

        private HashSet<string> getSavedPostsIds()
        {
            List<string> savedPosts = FileManager.LoadFromFile<List<string>>(FileManager.k_SavedPostsFilePath);

            HashSet<string> set = new HashSet<string>(savedPosts);

            return set;
        }
    }
}
