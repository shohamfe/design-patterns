using FacebookWrapper.ObjectModel;

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

        public Post RawData { get; set; }

        public PostDetails() { }

        public PostDetails(Post i_RawData, string i_FullName, string i_imageUrl, string i_PostTime, string i_PostText, string i_PictureURL, int? i_PostLikes = 0, int? i_PostComments = 0)
        {
            RawData = i_RawData;
            FullName = i_FullName;
            ImageURL = i_imageUrl;
            PostTime = i_PostTime;
            PostText = i_PostText;
            PictureURL = i_PictureURL;
            PostLikes = i_PostLikes ?? 0;
            PostComments = i_PostComments ?? 0;
        }
    }
}
