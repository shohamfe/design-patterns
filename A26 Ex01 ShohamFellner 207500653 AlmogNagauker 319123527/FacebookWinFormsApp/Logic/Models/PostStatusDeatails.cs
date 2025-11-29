using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Logic.Models
{
    public class PostStatusDeatails
    {
        public string FullName { get; set; }

        public string ImageURL { get; set; }

        public string PostTime { get; set; }

        public string PostText { get; set; }

        public int postLikes { get; set; }

        public int postComments { get; set; }

        public string pictureURL { get; set; }

        public PostStatusDeatails(string i_FullName,string i_imageUrl, string i_PostTime, string i_PostText,string i_PictureURL, int i_PostLikes, int i_PostComments)
        {
            FullName = i_FullName;
            ImageURL = i_imageUrl;
            PostTime = i_PostTime;
            PostText = i_PostText; 
            pictureURL = i_PictureURL;
            postLikes = i_PostLikes;
            postComments = i_PostComments;
        }
    }
}
