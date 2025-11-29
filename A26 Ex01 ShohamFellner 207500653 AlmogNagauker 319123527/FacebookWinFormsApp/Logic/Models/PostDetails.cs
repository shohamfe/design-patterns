using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Logic.Models
{
    public class PostDetails
    {
        public string FullName { get; set; }

        public string ImageURL { get; set; }

        public string PostTime { get; set; }

        public string PostText { get; set; }

        public int PostLikes { get; set; }

        public int PostComments { get; set; }

        public string PictureURL { get; set; }

        public PostDetails(string i_FullName,string i_imageUrl, string i_PostTime, string i_PostText,string i_PictureURL) // , int i_PostLikes, int i_PostComments)
        {
            FullName = i_FullName;
            ImageURL = i_imageUrl;
            PostTime = i_PostTime;
            PostText = i_PostText; 
            PictureURL = i_PictureURL;
            //PostLikes = i_PostLikes;
            //PostComments = i_PostComments;
        }
    }
}
