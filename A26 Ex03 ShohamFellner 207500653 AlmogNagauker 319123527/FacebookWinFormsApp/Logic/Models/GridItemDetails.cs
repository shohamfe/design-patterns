namespace BasicFacebookFeatures.Logic.Models
{
    public class GridItemDetails
    {
        public string Label { get; set; }

        public string ImageUrl { get; set; }

        public object RawData { get; set; }

        public GridItemDetails(string i_MainText, string i_ImageUrl, object i_RawData)
        {
            Label = i_MainText;
            ImageUrl = i_ImageUrl;
            RawData = i_RawData;
        }
    }
}
