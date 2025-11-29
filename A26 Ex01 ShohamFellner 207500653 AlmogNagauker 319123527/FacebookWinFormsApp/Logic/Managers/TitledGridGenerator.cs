using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Models;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures.Logic.Managers
{
    public class TitledGridGenerator<T>
    {
        private readonly IGridItemManager<T> r_Manager;

        public TitledGridGenerator(IGridItemManager<T> i_Manager)
        {
            r_Manager = i_Manager;
        }

        public TitledGridDetails GenerateGrid(string i_Title)
        {
            List<GridItemDetails> itemsList = new List<GridItemDetails>();
            FacebookObjectCollection<object> rawCollectionAsObject = new FacebookObjectCollection<object>();

            FacebookObjectCollection<T> rawCollection = r_Manager.GetCollection();

            if (rawCollection != null)
            {
                foreach (T item in rawCollection)
                {
                    string text = r_Manager.GetTitle(item);
                    string imageUrl = r_Manager.GetImageUrl(item);

                    itemsList.Add(new GridItemDetails(text, imageUrl, item));
                    rawCollectionAsObject.Add(item);
                }
            }

            return new TitledGridDetails(i_Title, itemsList, rawCollectionAsObject);
        }
    }
}
