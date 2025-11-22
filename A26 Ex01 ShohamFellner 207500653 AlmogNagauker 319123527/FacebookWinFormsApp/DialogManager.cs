using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class DialogManager
    {
        private FacebookWrapper.LoginResult m_LoginResult;

        private LoginFormMain m_LoginFormMain = new LoginFormMain();
        private FacebookMain m_FacebookMain;

        public DialogManager()
        {
            m_LoginFormMain.LoggedInEventHandler += loginFormMain_LoggedIn;
        }

        private void loginFormMain_LoggedIn(object sender, FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;

            m_LoginFormMain.Hide();

            if (m_FacebookMain == null)
            {
                m_FacebookMain = new FacebookMain(ref m_LoginResult);
            }

            m_FacebookMain.Show();
        }

        public void RunLogin()
        {
            Application.Run(m_LoginFormMain);
        }

        // add event listener from loginform: after login success -> hide login form and show facebook main
    }
}
