using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Models;

namespace BasicFacebookFeatures.Logic.Commands
{
    public class LikePostCommand : IToggleCommand
    {
        private readonly PostDetails m_Post;
        private bool m_isActive = false;

        public LikePostCommand(PostDetails i_Post)
        {
            m_Post = i_Post;
        }

        public void Execute()
        {
            if (!m_isActive)
            {
                m_Post.PostLikes++;
            }
            else if (m_Post.PostLikes > 0)
            {
                m_Post.PostLikes--;
            }

            m_isActive = !m_isActive;
        }
    }
}
