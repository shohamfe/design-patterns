using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class BioManager
    {
        private FacebookWrapper.LoginResult m_LoginResult;

        // TOOD: check naming conventions
        private enum BioKeys
        {
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

        private List<BioKeys> m_FieldsOrder = new List<BioKeys>
        {
            BioKeys.Name,
            BioKeys.MiddleName,
            BioKeys.Link,
            BioKeys.Birthday,
            BioKeys.Email,
            BioKeys.Gender,
            BioKeys.Relationship,
            BioKeys.Work,
            BioKeys.HomeTown,
            BioKeys.Languages
        };

        private readonly Dictionary<BioKeys, string> m_Keys = new Dictionary<BioKeys, string>
        {
            { BioKeys.Name, "name" },
            { BioKeys.FirstName, "first_name" },
            { BioKeys.LastName, "last_name" },
            { BioKeys.MiddleName, "middle_name" },
            { BioKeys.Link, "link" },
            { BioKeys.Gender, "gender" },
            { BioKeys.Birthday, "birthday" },
            { BioKeys.Email, "email" },
            { BioKeys.Relationship, "relationship_status" },
            { BioKeys.HomeTown, "hometown" },
            { BioKeys.Work, "work" },
            { BioKeys.Languages, "languages" }
        };

        private string m_FullName;
        private List<KeyValuePair<string, string>> m_Data = new List<KeyValuePair<string, string>>();

        public BioManager(FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;

            if (m_LoginResult.LoggedInUser != null)
            {
            }
        }

    }
}
