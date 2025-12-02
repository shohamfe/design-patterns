using BasicFacebookFeatures.Enums;
using BasicFacebookFeatures.Logic.Models;
using System.Drawing;

namespace BasicFacebookFeatures.Factories
{
    public static class ThemeFactory
    {
        public static AppTheme CreateTheme(eThemeType i_Type)
        {
            AppTheme theme = null;

            switch (i_Type)
            {
                case eThemeType.Default:
                    theme = new AppTheme
                    {
                        PrimaryBackColor = ColorTranslator.FromHtml("#f2f4f7"),
                        PanelBackColor = Color.White,
                        SecondaryPanelColor = Color.WhiteSmoke,
                        PrimaryTextColor = Color.Black,
                        SecondaryTextColor = ColorTranslator.FromHtml("#6B7280"),
                    };
                    break;

                case eThemeType.FacebookDark:
                    theme = new AppTheme
                    {
                        PrimaryBackColor = ColorTranslator.FromHtml("#18191A"),
                        PanelBackColor = ColorTranslator.FromHtml("#242526"),
                        SecondaryPanelColor = ColorTranslator.FromHtml("#3A3B3C"),
                        PrimaryTextColor = ColorTranslator.FromHtml("#E4E6EB"),
                        SecondaryTextColor = ColorTranslator.FromHtml("#B0B3B8"),
                    };
                    break;

                case eThemeType.CleanSlate:
                    theme = new AppTheme
                    {
                        PrimaryBackColor = ColorTranslator.FromHtml("#F3F4F6"),
                        PanelBackColor = Color.White,
                        PrimaryTextColor = ColorTranslator.FromHtml("#111827"),
                        SecondaryTextColor = ColorTranslator.FromHtml("#6B7280"),
                        AccentColor = ColorTranslator.FromHtml("#374151"),
                        ButtonTextColor = Color.White
                    };
                    break;

                case eThemeType.SepiaReader:
                    theme = new AppTheme
                    {
                        PrimaryBackColor = ColorTranslator.FromHtml("#F4ECD8"),
                        PanelBackColor = ColorTranslator.FromHtml("#FDF6E3"),
                        PrimaryTextColor = ColorTranslator.FromHtml("#5F4B32"),
                        SecondaryTextColor = ColorTranslator.FromHtml("#927C5B"),
                        AccentColor = ColorTranslator.FromHtml("#D65D0E"),
                        ButtonTextColor = Color.White
                    };
                    break;

                case eThemeType.CyberNeon:
                    theme = new AppTheme
                    {
                        PrimaryBackColor = ColorTranslator.FromHtml("#0D1117"),
                        PanelBackColor = ColorTranslator.FromHtml("#161B22"),
                        PrimaryTextColor = ColorTranslator.FromHtml("#C9D1D9"),
                        SecondaryTextColor = ColorTranslator.FromHtml("#8B949E"),
                        AccentColor = ColorTranslator.FromHtml("#00E676"),
                        ButtonTextColor = Color.Black
                    };
                    break;

                case eThemeType.OceanBreeze:
                    theme = new AppTheme
                    {
                        PrimaryBackColor = ColorTranslator.FromHtml("#E0F7FA"),
                        PanelBackColor = Color.White,
                        PrimaryTextColor = ColorTranslator.FromHtml("#006064"),
                        SecondaryTextColor = ColorTranslator.FromHtml("#0097A7"),
                        AccentColor = ColorTranslator.FromHtml("#00BCD4"),
                        ButtonTextColor = Color.White
                    };
                    break;

                default:
                    theme = CreateTheme(eThemeType.Default);
                    break;
            }

            return theme;
        }
    }
}
