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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
