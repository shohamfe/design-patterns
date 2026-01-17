using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Interfaces
{
    public interface IGridItemManager<T>
    {
        FacebookObjectCollection<T> GetCollection();

        string GetImageUrl(T i_Item);

        string GetTitle(T i_Item);
    }
}
