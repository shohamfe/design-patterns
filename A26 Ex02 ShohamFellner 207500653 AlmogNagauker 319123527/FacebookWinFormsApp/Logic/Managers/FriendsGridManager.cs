using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Singletons;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.Managers
{
    public class FriendsGridManager : IGridItemManager<User>
    {
        public FacebookObjectCollection<User> GetCollection()
        {
            return FacebookSession.Instance.User?.Friends;
        }

        public string GetImageUrl(User i_Item)
        {
            return i_Item.PictureNormalURL;
        }

        public string GetTitle(User i_Item)
        {
            return i_Item.Name;
        }
    }
}