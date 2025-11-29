using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using BasicFacebookFeatures.Logic.Models;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.Managers
{
    internal class PostStatusGridManager
    {
        private FacebookWrapper.LoginResult m_LoginResult;
        
        public PostStatusGridManager(FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
        }
        
        public PostStatusDeatails GetPostStatusDeatails()
        {
            FacebookObjectCollection<Post> posts = m_LoginResult.LoggedInUser.Posts;
            string title = "Posts";
            List<PostStatusDeatails> postStatusDeatailsList = new List<PostStatusDeatails>();
            FacebookObjectCollection<object> postAsObject = new FacebookObjectCollection<object>();

            foreach (Post post in posts)
            {
                if (!string.IsNullOrEmpty(post.Message))
                {
                    PostStatusDeatails postStatusDeatails = new PostStatusDeatails(
                        m_LoginResult.LoggedInUser.Name,
                        m_LoginResult.LoggedInUser.PictureLargeURL,
                        post.CreatedTime.Value.ToString(),
                        post.Message,
                        post.PictureURL,
                        post.LikedBy.Count, 
                        post.Comments.Count
                    ); 
                    postStatusDeatailsList.Add(postStatusDeatails);
                    
                    postAsObject.Add(post);
                }

                // TitledGridDetails details = new TitledGridDetails(title, ); 
                
            }

            return postStatusDeatailsList[0];
        }
        
    }
}
