using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Singletons;

namespace BasicFacebookFeatures.Logic.Managers
{
    public class AlbumsGridManager : IGridItemManager<Album>
    {
        public FacebookObjectCollection<Album> GetCollection()
        {
            return FacebookSessionSingleton.Instance.LoggedInUser?.Albums;
        }

        public string GetImageUrl(Album i_Item)
        {
            return i_Item.PictureSmallURL;
        }

        public string GetTitle(Album i_Item)
        {
            return i_Item.Name;
        }
    }
}
