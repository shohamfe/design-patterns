using BasicFacebookFeatures.Enums;
using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Managers;

namespace BasicFacebookFeatures.Factories
{
    public static class GridManagerFactory
    {
        public static IGridItemManager<T> Create<T>(eGridItemType i_Type)
        {
            IGridItemManager<T> manager = null;

            switch (i_Type)
            {
                case eGridItemType.Albums:
                    manager = new AlbumsGridManager() as IGridItemManager<T>;
                    break;

                case eGridItemType.Friends:
                    manager = new FriendsGridManager() as IGridItemManager<T>;
                    break;

                case eGridItemType.LikedPages:
                    manager = new LikedPagesGridManager() as IGridItemManager<T>;
                    break;

                default:
                    break;
            }

            return manager;
        }
    }
}
