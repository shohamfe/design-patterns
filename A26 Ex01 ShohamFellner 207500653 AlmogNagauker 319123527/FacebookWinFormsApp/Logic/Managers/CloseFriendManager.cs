using System;
using System.Collections.Generic;
using System.IO;
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
            string CloseFriendsJsonData = File.ReadAllText(r_FilePath);

            CloseFriendsList nameData = JsonConvert.DeserializeObject<CloseFriendsList>(CloseFriendsJsonData);

            return nameData.close_friends_list != null
                ? new HashSet<string>(nameData.close_friends_list)
                : new HashSet<string>();
        }
    }
}
