using BasicFacebookFeatures.Logic.Models;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.Managers
{
    public class AlbumsGridManager
    {
        private FacebookWrapper.LoginResult m_LoginResult;

        public AlbumsGridManager(FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
        }

        public TitledGridDetails GetTitledGridDetails<T>()
        {
            FacebookObjectCollection<Album> albums = m_LoginResult.LoggedInUser.Albums;

            string title = "Albums";
            List<GridItemDetails> gridItems = new List<GridItemDetails>();
            FacebookObjectCollection<object> albumsAsObjects = new FacebookObjectCollection<object>();


            foreach (Album album in albums)
            {
                GridItemDetails item = new GridItemDetails(
                    album.Name,
                    album.PictureThumbURL,
                    album
                );
                gridItems.Add(item);

                albumsAsObjects.Add(album);
            }


            TitledGridDetails details = new TitledGridDetails(title, gridItems, albumsAsObjects);

            return details;
        }
    }
}
