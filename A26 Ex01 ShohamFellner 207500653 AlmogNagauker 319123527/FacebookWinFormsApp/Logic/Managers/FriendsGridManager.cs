using BasicFacebookFeatures.Logic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Logic.Managers
{

    public class FriendsGridManager
    {
        private FacebookWrapper.LoginResult m_LoginResult;

        public FriendsGridManager(FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
        }

        public TitledGridDetails GetTitledGridDetails<T>()
        {
            FacebookObjectCollection<User> friends = m_LoginResult.LoggedInUser.Friends;

            string title = "Friends";
            List<GridItemDetails> gridItems = new List<GridItemDetails>();
            FacebookObjectCollection<object> friendsAsObjects = new FacebookObjectCollection<object>();


            foreach (User friend in friends)
            {
                GridItemDetails item = new GridItemDetails(
                    friend.Name,
                    friend.PictureNormalURL,
                    friend
                );
                gridItems.Add(item);

                friendsAsObjects.Add(friend);
            }


            TitledGridDetails details = new TitledGridDetails(title, gridItems, friendsAsObjects);

            return details;
        }
    }
}
