using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Logic.Models
{
    public class PostDeatails
    {
        public string FullName { get; set; }

        public DateTime PostTime { get; set; }

        public string PostText { get; set; }

        public PostDeatails(string i_FullName, DateTime i_PostTime, string i_PostText)
        {
            FullName = i_FullName;
            PostTime = i_PostTime;
            PostText = i_PostText; 
        }
    }
}
