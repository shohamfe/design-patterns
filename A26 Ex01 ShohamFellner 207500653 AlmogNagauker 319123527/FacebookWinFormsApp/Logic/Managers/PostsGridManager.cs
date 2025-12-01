using BasicFacebookFeatures.Logic.Models;
using BasicFacebookFeatures.Singletons;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures.Logic.Managers
{
    public class PostsGridManager
    {
        public PostGridDetails GetPostDetails()
        {
            string title = "Posts";
            List<PostDetails> postDetailsList = new List<PostDetails>();

            User user = FacebookSessionSingleton.Instance.LoggedInUser;
            FacebookObjectCollection<Post> posts = null; 
            if (user != null)
            {
                posts = user.Posts;
            }

            if (posts != null)
            {

                foreach (Post post in posts)
                {
                    if (!string.IsNullOrEmpty(post.Message))
                    {
                        PostDetails postDetails = new PostDetails(
                            post,
                            user.Name,
                            user.PictureNormalURL,
                            post.CreatedTime.Value.ToString(),
                            post.Message,
                            post.PictureURL,
                            getPostLikes(post),
                            getPostComments(post)
                        );

                        postDetailsList.Add(postDetails);
                    }
                }
            }

            return new PostGridDetails(title, postDetailsList);
        }

        int getPostLikes(Post i_Post)
        {
            int likesCount = 0;
            try
            {
                likesCount = i_Post.LikedBy.Count;
            }
            catch
            {
                // in case of permission issues, return 0
            }
            return likesCount;
        }

        int getPostComments(Post i_Post)
        {
            int commentsCount = 0;
            try
            {
                commentsCount = i_Post.Comments.Count;
            }
            catch
            {
                // in case of permission issues, return 0
            }
            return commentsCount;
        }

        public void LikePost(Post i_post)
        {
            try
            {
                i_post.Like();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to like post", ex);
            }
        }
    }
}
