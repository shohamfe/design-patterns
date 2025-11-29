using System.Collections.Generic;

namespace BasicFacebookFeatures.Logic.Models
{
    public class TitledGridDetails
    {
        public string Title { get; set; }

        public List<GridItemDetails> Items { get; set; }

        public TitledGridDetails(string i_Title, List<GridItemDetails> i_Items)
        {
            Title = i_Title;
            Items = i_Items;
        }
    }
}
