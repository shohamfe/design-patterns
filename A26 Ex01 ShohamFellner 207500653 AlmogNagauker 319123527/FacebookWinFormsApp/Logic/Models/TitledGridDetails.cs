using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.Models
{
    public class TitledGridDetails
    {
        public string Title { get; set; }
        public List<GridItemDetails> Items { get; set; }

        public FacebookObjectCollection<object> RawData { get; set; }

        public TitledGridDetails(string i_Title, List<GridItemDetails> i_Items, FacebookObjectCollection<object> i_RawData)
        {
            Title = i_Title;
            Items = i_Items;
            RawData = i_RawData;
        }
    }
}
