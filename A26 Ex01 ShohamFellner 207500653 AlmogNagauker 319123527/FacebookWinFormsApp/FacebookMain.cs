using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FacebookMain : Form
    {
        private FacebookWrapper.LoginResult m_LoginResult;

        public FacebookMain(ref FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
            InitializeComponent();
        }

        private void FacebookMain_Load(object sender, EventArgs e)
        {
            pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureLargeURL;

            pictureBox1.ImageLocation = m_LoginResult.LoggedInUser.PictureSmallURL;
        }
    }
}
