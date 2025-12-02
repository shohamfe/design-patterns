using BasicFacebookFeatures.Enums;
using BasicFacebookFeatures.Factories;
using BasicFacebookFeatures.Logic.Models;
using System;

namespace BasicFacebookFeatures.Singletons
{
    public sealed class ThemeManager
    {
        private static ThemeManager s_Instance;
        
        private static readonly object sr_LockContext = new object();

        public event Action<AppTheme> ThemeChanged;

        private AppTheme m_CurrentTheme;

        private ThemeManager()
        {
            m_CurrentTheme = ThemeFactory.CreateTheme(eThemeType.Default);
        }

        public static ThemeManager Instance
        {
            get
            {
                lock (sr_LockContext)
                {
                    if (s_Instance == null)
                    {
                        s_Instance = new ThemeManager();
                    }
                }

                return s_Instance;
            }
        }

        public AppTheme CurrentTheme
        {
            get { return m_CurrentTheme; }
        }

        public void SetTheme(eThemeType i_ThemeType)
        {
            m_CurrentTheme = ThemeFactory.CreateTheme(i_ThemeType);

            if (ThemeChanged != null)
            {
                ThemeChanged.Invoke(m_CurrentTheme);
            }
        }
    }
}
