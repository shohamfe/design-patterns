using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.Models
{
    public class PostGridDeatails
    {
        public string Title { get; set; }

        public List<PostDetails> Items { get; set; }

        public FacebookObjectCollection<object> RawData { get; set; }

        public PostGridDeatails(string i_Title, List<PostDetails> i_Items, FacebookObjectCollection<object> i_RawData)
        {
            Title = i_Title;
            Items = i_Items;
            RawData = i_RawData;
        }

    }
}
