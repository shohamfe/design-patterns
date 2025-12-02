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

        public static void SaveToFile<T>(T i_DataToSave, string i_FilePath)
        {
            using (Stream stream = new FileStream(i_FilePath, FileMode.Truncate))
            {
                JsonSerializer.Serialize<T>(stream, i_DataToSave);
            }
        }

        public static T LoadFromFile<T>(string i_FilePath)
        {
            T data = default(T);

            if (File.Exists(i_FilePath))
            {
                using (Stream stream = new FileStream(i_FilePath, FileMode.Open))
                {
                    if (stream.Length > 0)
                    {
                        data = JsonSerializer.Deserialize<T>(stream);
                    }
                }
            }

            return data;
        }
    }
}
