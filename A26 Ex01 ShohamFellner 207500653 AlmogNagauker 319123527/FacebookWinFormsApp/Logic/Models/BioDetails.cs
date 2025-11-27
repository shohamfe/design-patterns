using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Logic
{
    public class BioDetails
    {
        // TOOD: check naming conventions
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
            Work,
            Languages

        }

        private readonly List<eBioKeys> m_BioFieldsOrder = new List<eBioKeys>
        {
            eBioKeys.Name,
            eBioKeys.MiddleName,
            eBioKeys.Birthday,
            eBioKeys.Email,
            eBioKeys.Gender,
            eBioKeys.Relationship,
            eBioKeys.Work,
            eBioKeys.HomeTown,
            eBioKeys.Languages
        };

        private readonly List<eBioKeys> m_AdditionalInfoFieldsOrder = new List<eBioKeys>
        {
            eBioKeys.FirstName,
            eBioKeys.LastName,
            eBioKeys.Link
        };

        private readonly Dictionary<eBioKeys, string> m_Data = new Dictionary<eBioKeys, string>();

        public Dictionary<eBioKeys, string> Data { get { return m_Data; } }
        public string Link { get { return Data[eBioKeys.Link]; } }
        public string FullName { get { return Data[eBioKeys.FullName]; } }

        public string GetBioDetailsAsString()
        {
            StringBuilder bioDetailsStringBuilder = new StringBuilder();
            string value;

            foreach (eBioKeys key in m_BioFieldsOrder)
            {
                if (Data.TryGetValue(key, out value) && !string.IsNullOrEmpty(value))
                {
                    bioDetailsStringBuilder.AppendLine(string.Format("{0}: {1}", key, value));
                }
            }

            return bioDetailsStringBuilder.ToString();
        }

        public string GetAdditionalInfoAsString()
        {
            StringBuilder additionalInfoStringBuilder = new StringBuilder();
            string value;
            foreach (eBioKeys key in m_BioFieldsOrder)
            {
                if (Data.TryGetValue(key, out value) && !string.IsNullOrEmpty(value))
                {
                    additionalInfoStringBuilder.AppendLine(string.Format("{0}: {1}", key, value));
                }
            }
            return additionalInfoStringBuilder.ToString();
        }
    }
}
