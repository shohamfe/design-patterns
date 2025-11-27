using BasicFacebookFeatures.Logic;
using System;
using System.Collections.Generic;
using System.Linq;

using static BasicFacebookFeatures.Logic.BioDetails;

namespace BasicFacebookFeatures
{
    public class BioManager
    {
        private FacebookWrapper.LoginResult m_LoginResult;

        public BioManager(FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;

        }

        public BioDetails GetBioDetails()
        {
            FacebookWrapper.ObjectModel.User user = m_LoginResult.LoggedInUser;
            
            BioDetails bioDetails = new BioDetails();

            if (user != null)
            {
                bioDetails.Data.Add(eBioKeys.Name, user.Name);
                bioDetails.Data.Add(eBioKeys.FirstName, user.FirstName);
                bioDetails.Data.Add(eBioKeys.LastName, user.LastName);
                bioDetails.Data.Add(eBioKeys.MiddleName, user.MiddleName);
                bioDetails.Data.Add(eBioKeys.Link, user.Link);
                bioDetails.Data.Add(eBioKeys.Gender, user.Gender.Value.ToString());
                bioDetails.Data.Add(eBioKeys.Birthday, user.Birthday);
                bioDetails.Data.Add(eBioKeys.Email, user.Email);
                bioDetails.Data.Add(eBioKeys.Relationship, user.RelationshipStatus.Value.ToString());
                bioDetails.Data.Add(eBioKeys.HomeTown, user.Hometown != null ? user.Hometown.Name : null);
                bioDetails.Data.Add(eBioKeys.Work, formatWork(user.WorkExperiences));
                bioDetails.Data.Add(eBioKeys.Languages, formatLanguages(user.Languages));

                string fullName = String.Join(" ", bioDetails.Data[eBioKeys.FirstName], bioDetails.Data[eBioKeys.MiddleName], bioDetails.Data[eBioKeys.LastName]).Replace("  ", " ");
                bioDetails.Data.Add(eBioKeys.FullName, fullName);
            }

            return bioDetails;
        }

        // TODO: Go over those functions
        private string formatWork(
            System.Collections.Generic.IEnumerable<FacebookWrapper.ObjectModel.WorkExperience> i_WorkExperiences)
        {
            if (i_WorkExperiences == null)
            {
                return null;
            }

            List<string> parts = i_WorkExperiences
                .Where(w => w != null && w.Employer != null && !string.IsNullOrEmpty(w.Employer.Name))
                .Select(w =>
                {
                    string employer = w.Employer.Name;
                    string position = (w.Position != null && !string.IsNullOrEmpty(w.Position.Name)) ? w.Position.Name : null;

                    return string.IsNullOrEmpty(position) ? employer : string.Format("{0} ({1})", employer, position);
                })
                .ToList();

            return parts.Count > 0 ? string.Join(", ", parts) : null;
        }

        private string formatLanguages(
            System.Collections.Generic.IEnumerable<FacebookWrapper.ObjectModel.Page> i_Languages)
        {
            if (i_Languages == null)
            {
                return null;
            }

            List<string> names = i_Languages
                .Where(l => l != null && !string.IsNullOrEmpty(l.Name))
                .Select(l => l.Name)
                .ToList();

            return names.Count > 0 ? string.Join(", ", names) : null;
        }
    }
}
