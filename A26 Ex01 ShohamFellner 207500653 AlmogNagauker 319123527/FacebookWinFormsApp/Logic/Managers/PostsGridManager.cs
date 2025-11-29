using System;
using System.Collections.Generic;
using BasicFacebookFeatures.Logic.Models;
using BasicFacebookFeatures.Singletons;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.Managers
{
    public class PostsGridManager
    {         
        public PostGridDeatails GetPostDetails()
        {
            User user = FacebookSessionSingleton.Instance.LoggedInUser;

            var test = user.Friends?[0]?.Posts;

            FacebookObjectCollection<Post> posts = user.Posts;
            string title = "Posts";
            List<PostDetails> postDetailsList = new List<PostDetails>();
            FacebookObjectCollection<object> postAsObject = new FacebookObjectCollection<object>();

            foreach (Post post in posts)
            {
                if (!string.IsNullOrEmpty(post.Message))
                {
                    PostDetails postDetails = new PostDetails(
                        user.Name,
                        user.PictureNormalURL,
                        post.CreatedTime.Value.ToString(),
                        post.Message,
                        post.PictureURL
                        //post.LikedBy.Count, 
                        //post.Comments.Count
                    ); 
                    postDetailsList.Add(postDetails);
                    
                }
                postAsObject.Add(post);

            }
            return new PostGridDeatails(title, postDetailsList, postAsObject); 
           
        }
        
    }
}
