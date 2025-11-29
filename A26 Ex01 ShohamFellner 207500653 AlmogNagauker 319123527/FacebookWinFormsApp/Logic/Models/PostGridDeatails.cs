using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.Models
{
    public class PostGridDetails
    {
        public string Title { get; set; }

        public List<PostDetails> Items { get; set; }

        public FacebookObjectCollection<object> RawData { get; set; }

        public PostGridDetails(string i_Title, List<PostDetails> i_Items, FacebookObjectCollection<object> i_RawData)
        {
            Title = i_Title;
            Items = i_Items;
            RawData = i_RawData;
        }

    }
}
