using System.Collections.Generic;
using System.IO;
using BasicFacebookFeatures.Logic.Models;
using FacebookWrapper.ObjectModel;
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

        public FacebookObjectCollection<Post> LoadFeedFromFile()
        {
            string postJsonData = File.ReadAllText(r_FeedFilePath);

            FacebookObjectCollection<Post> feed = JsonConvert.DeserializeObject<FacebookObjectCollection<Post>>(postJsonData);

            return feed;
        }
    }
}