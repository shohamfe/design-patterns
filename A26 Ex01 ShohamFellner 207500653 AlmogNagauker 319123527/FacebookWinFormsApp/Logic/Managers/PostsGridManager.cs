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

                foreach (Post post in i_Posts)
                {
                    if (!string.IsNullOrEmpty(post.Message))
                    {
                        PostDetails postDetails = new PostDetails(
                            post,
                            post.Name ?? FacebookSessionSingleton.Instance.LoggedInUser.Name,
                            post.IconURL ?? FacebookSessionSingleton.Instance.LoggedInUser.PictureSmallURL,
                            post.CreatedTime.Value.ToString(),
                            post.Message,
                            post.PictureURL
                        );

                        postDetailsList.Add(postDetails);
                    }
                }
            }

            return new PostGridDetails(i_Title, postDetailsList);
        }
    }
}
