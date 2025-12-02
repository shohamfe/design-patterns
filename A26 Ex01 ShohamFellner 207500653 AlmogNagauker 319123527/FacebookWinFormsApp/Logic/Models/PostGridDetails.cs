using System.Collections.Generic;

namespace BasicFacebookFeatures.Logic.Models
{
    public class PostGridDetails
    {
        public string Title { get; set; }

        public List<PostDetails> Items { get; set; }

        public PostGridDetails(string i_Title, List<PostDetails> i_Items)
        {
            Title = i_Title;
            Items = i_Items;
        }
    }
}
