using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Models;
using BasicFacebookFeatures.Singletons;
using System.IO;
using System.Windows;

namespace BasicFacebookFeatures.Logic.Command
{
    public class CloseFriendCommand : IToggleCommand
    {
        private readonly PostDetails m_Post;

        public CloseFriendCommand(PostDetails i_Post)
        {
            m_Post = i_Post;
        }

        public void Execute()
        {
            toggleState();
        }

        private void toggleState()
        {
            try
            {
                FacebookSession.Instance.User.UpdateCloseFriendState(m_Post.UserId, m_Post.IsCloseFriends);

            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error in ToggleCloseFriendCommand: {ex.Message}", "Error");
            }
        }
    }
}
