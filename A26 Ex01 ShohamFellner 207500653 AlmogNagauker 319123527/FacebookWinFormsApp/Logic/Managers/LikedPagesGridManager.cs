using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Singletons;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.Managers
{
    public class LikedPagesGridManager : IGridItemManager<Page>
    {
        public FacebookObjectCollection<Page> GetCollection()
        {
            return FacebookSessionSingleton.Instance.LoggedInUser?.LikedPages;
        }

        public string GetImageUrl(Page i_Item)
        {
            return i_Item.PictureNormalURL;
        }

        public string GetTitle(Page i_Item)
        {
            return i_Item.Name;
        }
    }
}
