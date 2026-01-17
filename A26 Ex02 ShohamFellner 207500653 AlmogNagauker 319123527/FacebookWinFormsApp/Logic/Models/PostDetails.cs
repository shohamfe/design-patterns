using BasicFacebookFeatures.Singletons;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.Models
{
    public class PostDetails
    {
        public PostDetails() { }

        public string PostId { get; set; }

        public string UserId
        {
            get
            {
                string userId = string.Empty;

                if (!string.IsNullOrEmpty(PostId))
                {
                    // Split on the first underscore and return the part before it.
                    var parts = PostId.Split(new[] { '_' }, 2);
                    userId = parts.Length > 0 ? parts[0] : string.Empty;
                }

                return userId;
            }
        }

        public string FullName { get; set; }

        public string ImageURL { get; set; }

        public string PostTime { get; set; }

        public string PostText { get; set; }

        public int PostLikes { get; set; }

        public int PostComments { get; set; }

        public string PictureURL { get; set; }

        public bool IsLoggedInUser { get { return FacebookSession.Instance.LoggedInUser.Id == UserId; } }

        public bool IsCloseFriends { get { return !IsLoggedInUser && FacebookSession.Instance.CloseFriendsIdSet.Contains(UserId); } }

        public Post RawData { get; set; }
    }
}
