using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Models;
namespace BasicFacebookFeatures.Logic.Command
{
    public class CommentPostCommand : IToggleCommand
    {
        private readonly PostDetails m_Post;
        private bool m_IsActive = false;

        public CommentPostCommand(PostDetails i_Post)
        {
            m_Post = i_Post;
        }

        public void Execute()
        {
            if (!m_IsActive)
            {
                m_Post.PostComments++;
            }
            else if(m_Post.PostComments > 0)
            {
                m_Post.PostComments--;
            }

            m_IsActive = !m_IsActive;
        }
    }
}
