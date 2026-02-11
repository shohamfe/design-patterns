using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Singletons;

namespace BasicFacebookFeatures.Logic.Managers
{
    public class AlbumsGridManager : IGridItemManager<Album>
    {
        public FacebookObjectCollection<Album> GetCollection()
        {
            return FacebookSession.Instance.User?.Albums;
        }

        public string GetImageUrl(Album i_Item)
        {
            return i_Item.PictureThumbURL;
        }

        public string GetTitle(Album i_Item)
        {
            return i_Item.Name;
        }
    }
}
