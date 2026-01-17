using BasicFacebookFeatures.Singletons;
using FacebookWrapper.ObjectModel;
using System;
using System.ComponentModel;

namespace BasicFacebookFeatures.Logic.Models
{
    public class PostDetails : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public PostDetails() { }

        private int m_PostComments;

        private int m_PostLikes;

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

        public DateTime PostDateTime
        {
            get
            {
                DateTime result = DateTime.MinValue;

                DateTime.TryParse(PostTime, out result);

                return result;
            }
        }

        public string PostText { get; set; }

        public int PostLikes
        {
            get { return m_PostLikes; }
            set
            {
                m_PostLikes = value;
                OnPropertyChanged("PostLikes");
            }
        }

        public int PostComments
        {
            get { return m_PostComments; }
            set
            {
                m_PostComments = value;
                OnPropertyChanged("PostComments");
            }
        }

        public string PictureURL { get; set; }

        public bool IsNotLoggedInUser { get { return FacebookSession.Instance.LoggedInUser.Id != UserId; } }

        public bool IsCloseFriends { get { return IsNotLoggedInUser && FacebookSession.Instance.CloseFriendsIdSet.Contains(UserId); } }

        public string CloseFriendsButtonText
        {
            get
            {
                return IsCloseFriends ? "Remove Close Friend" : "Save to Close Friends";
            }
        }

        public int StarImageIndex
        {
            get
            {
                return IsCloseFriends ? 1 : 0;
            }
        }

        public Post RawData { get; set; }

        public void UpdateCloseFriendsState()
        {
            OnPropertyChanged("IsCloseFriends");
            OnPropertyChanged("StarImageIndex");       // Update the Icon
            OnPropertyChanged("CloseFriendsButtonText"); // Update the Text
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
