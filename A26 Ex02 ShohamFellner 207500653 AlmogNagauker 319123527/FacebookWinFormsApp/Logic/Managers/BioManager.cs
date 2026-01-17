using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic;
using BasicFacebookFeatures.Singletons;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;

using static BasicFacebookFeatures.Logic.BioDetails;

namespace BasicFacebookFeatures
{
    public class BioManager
    {
        public BioManager() { }

        public BioDetails GetBioDetails()
        {
            IUser user = FacebookSession.Instance.LoggedInUser;

            BioDetails bioDetails = new BioDetails();

            if (user != null)
            {
                bioDetails.Data.Add(eBioKeys.Name, user.Name);
                bioDetails.Data.Add(eBioKeys.FirstName, user.FirstName);
                bioDetails.Data.Add(eBioKeys.LastName, user.LastName);
                bioDetails.Data.Add(eBioKeys.MiddleName, user.MiddleName);
                bioDetails.Data.Add(eBioKeys.Link, user.Link);
                bioDetails.Data.Add(eBioKeys.Gender, user.Gender.ToString());
                bioDetails.Data.Add(eBioKeys.Birthday, user.Birthday);
                bioDetails.Data.Add(eBioKeys.Email, user.Email);
                bioDetails.Data.Add(eBioKeys.Relationship, user.RelationshipStatus.ToString());
                bioDetails.Data.Add(eBioKeys.HomeTown, user.Hometown != null ? user.Hometown.Name : null);
                bioDetails.Data.Add(eBioKeys.Languages, formatLanguages(user.Languages));

                string fullName = string.Join(" ",
                    bioDetails.Data[eBioKeys.FirstName],
                    bioDetails.Data[eBioKeys.MiddleName],
                    bioDetails.Data[eBioKeys.LastName])
                    .Replace("  ", " ");

                bioDetails.Data.Add(eBioKeys.FullName, fullName);
            }

            return bioDetails;
        }

        private string formatLanguages(Page[] i_Languages)
        {
            string result = null;

            if (i_Languages != null)
            {
                List<string> names = i_Languages
                    .Where(languages => languages != null && !string.IsNullOrEmpty(languages.Name))
                    .Select(languages => languages.Name)
                    .ToList();

                if (names.Count > 0)
                {
                    result = string.Join(" ", names);
                }
            }

            return result;
        }
    }
}
