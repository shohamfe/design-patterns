using System.Collections.Generic;
using System.IO;
using BasicFacebookFeatures.Logic.Models;
using Newtonsoft.Json;

namespace BasicFacebookFeatures.Logic.Managers
{
    public class FeedManager
    {
        private readonly string r_FeedFilePath; 

        public FeedManager(string i_FeedFilePath)
        {
            r_FeedFilePath = i_FeedFilePath;
        }

        public List<PostDetails> LoadFeedFromFile()
        {
            string PostjsonData = File.ReadAllText(r_FeedFilePath);

            FeedRoot feed = JsonConvert.DeserializeObject<FeedRoot>(PostjsonData);

            return feed.feed_data;
        }
    }
}