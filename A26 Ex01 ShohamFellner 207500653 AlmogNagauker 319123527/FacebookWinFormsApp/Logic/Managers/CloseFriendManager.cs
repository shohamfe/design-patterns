using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 
using BasicFacebookFeatures.Logic.Models;
using Newtonsoft.Json;

namespace BasicFacebookFeatures.Logic.Managers
{
    public class CloseFriendManager
    {
        private readonly string r_FilePath;

        public CloseFriendManager(string i_FilePath)
        {
            r_FilePath = i_FilePath;
        }

        public HashSet<string> LoadCloseFriendsFromFile()
        {
            string closeFriendsJsonData = File.ReadAllText(r_FilePath);

            CloseFriendsList nameData = JsonConvert.DeserializeObject<CloseFriendsList>(closeFriendsJsonData);

            //fix this.. 

            return nameData.close_friends_list != null
                ? new HashSet<string>(nameData.close_friends_list)
                : new HashSet<string>();
        }
    }
}
