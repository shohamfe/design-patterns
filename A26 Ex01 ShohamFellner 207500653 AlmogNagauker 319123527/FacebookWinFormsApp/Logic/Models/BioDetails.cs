using System.Collections.Generic;
using System.Text;

namespace BasicFacebookFeatures.Logic
{
    public class BioDetails
    {
        public enum eBioKeys
        {
            FullName,
            Name,
            FirstName,
            LastName,
            MiddleName,
            Link,
            Gender,
            Birthday,
            Email,
            Relationship,
            HomeTown,
            Languages
        }

        private readonly List<eBioKeys> r_BioFieldsOrder = new List<eBioKeys>
        {
            eBioKeys.Name,
            eBioKeys.MiddleName,
            eBioKeys.Birthday,
            eBioKeys.Email,
            eBioKeys.Gender,
            eBioKeys.Relationship,
            eBioKeys.HomeTown,
            eBioKeys.Languages
        };

        private readonly Dictionary<eBioKeys, string> r_Data = new Dictionary<eBioKeys, string>();

        public Dictionary<eBioKeys, string> Data { get { return r_Data; } }
        public string Link { get { return Data[eBioKeys.Link]; } }
        public string FullName { get { return Data[eBioKeys.FullName]; } }

        public string GetBioDetailsAsString()
        {
            StringBuilder bioDetailsStringBuilder = new StringBuilder();
            string value;

            foreach (eBioKeys key in r_BioFieldsOrder)
            {
                if (Data.TryGetValue(key, out value) && !string.IsNullOrEmpty(value))
                {
                    bioDetailsStringBuilder.AppendLine(string.Format("{0}: {1}", key, value));
                }
            }

            return bioDetailsStringBuilder.ToString();
        }
    }
}
