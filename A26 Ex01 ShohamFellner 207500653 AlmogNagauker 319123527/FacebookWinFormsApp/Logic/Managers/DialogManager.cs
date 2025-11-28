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

        private MainForm m_MainForm = new MainForm();

        public DialogManager()
        {
            m_MainForm.UserLoggedInEventHandler += loginFormMain_LoggedIn;
        }

        private void loginFormMain_LoggedIn(object sender, FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
        }

        public void RunLogin()
        {
            Application.Run(m_MainForm);
        }

        // add event listener from loginform: after login success -> hide login form and show facebook main
    }
}
