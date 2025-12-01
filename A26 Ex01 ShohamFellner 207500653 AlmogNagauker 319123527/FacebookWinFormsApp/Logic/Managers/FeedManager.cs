using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
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
            string jsonData = File.ReadAllText(r_FeedFilePath);

            FeedRoot feed = JsonConvert.DeserializeObject<FeedRoot>(jsonData);

            return feed.feed_data;
        }
    }
}