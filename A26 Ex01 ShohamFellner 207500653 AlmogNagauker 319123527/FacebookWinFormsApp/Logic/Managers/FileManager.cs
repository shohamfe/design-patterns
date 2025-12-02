using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BasicFacebookFeatures.Logic.Managers
{
    public static class FileManager
    {
        public const string k_FeedFilePath = "Resources/MockData/Json/mock_friend_feed.json";
        public const string k_CloseFriendsFilePath = "Resources/MockData/Json/mock_close_friends.json";
        public const string k_SavedPostsFilePath = "Resources/MockData/Json/mock_saved_posts.json";

        private static readonly object sr_ReadLockContext = new object();
        private static readonly object sr_WriteLockContext = new object();
 
        public static List<T> GetListFromFile<T>(string i_FilePath)
        {
            List<T> list = null;

            lock (sr_ReadLockContext)
            {
                if (File.Exists(i_FilePath))
                {
                    string jsonData = File.ReadAllText(i_FilePath);

                    try
                    {
                        list = JsonSerializer.Deserialize<List<T>>(jsonData);
                    }
                    catch { }
                }
            }

            if (list == null)
            {
                list = new List<T>();
            }

            return list;
        }

        public static void SaveToFile<T>(T i_DataToSave, string i_FilePath)
        {
            JsonSerializerOptions jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            lock (sr_WriteLockContext)
            {
                string jsonString = JsonSerializer.Serialize(i_DataToSave, jsonOptions);

                File.WriteAllText(i_FilePath, jsonString);
            }
        }
    }
}
