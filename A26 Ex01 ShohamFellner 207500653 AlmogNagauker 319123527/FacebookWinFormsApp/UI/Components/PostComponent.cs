using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic.Models;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class PostComponent : UserControl
    {
        public PostComponent()
        {
            InitializeComponent();
        }


        public void populate(PostStatusDeatails i_Details)
        {
            if (i_Details == null)
            {
                postAuthorProfilePicture.ImageLocation = i_Details.ImageURL;
                PostAuthorName.Text = i_Details.FullName;
                PostDate.Text = i_Details.PostTime;
                PostText.Text = i_Details.PostText;
                CountOfLike.Text = i_Details.postLikes.ToString();
                CountOfComments.Text = i_Details.postComments.ToString();
            }
        }

    }

}
   