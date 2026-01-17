using BasicFacebookFeatures.Enums;
using BasicFacebookFeatures.Factories;
using BasicFacebookFeatures.Logic.Infrastructure;
using BasicFacebookFeatures.Logic.Models;
using System;

namespace BasicFacebookFeatures.Singletons
{
    public sealed class ThemeManager
    {
        public event Action<AppTheme> ThemeChanged;

        private AppTheme m_CurrentTheme;

        private ThemeManager()
        {
            m_CurrentTheme = ThemeFactory.Create(eThemeType.Default);
        }

        public static ThemeManager Instance
        {
            get
            {
                return Singleton<ThemeManager>.Instance;
            }
        }

        public AppTheme CurrentTheme
        {
            get { return m_CurrentTheme; }
        }

        public void SetTheme(eThemeType i_ThemeType)
        {
            m_CurrentTheme = ThemeFactory.Create(i_ThemeType);

            if (ThemeChanged != null)
            {
                ThemeChanged.Invoke(m_CurrentTheme);
            }
        }
    }
}
