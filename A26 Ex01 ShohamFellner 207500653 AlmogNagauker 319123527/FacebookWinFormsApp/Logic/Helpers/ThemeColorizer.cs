using BasicFacebookFeatures.Logic.Models;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Logic.Helpers
{
    public static class ThemeColorizer
    {
        public static void ApplyTheme(Control i_Container, AppTheme i_AppTheme)
        {
            if (i_Container != null && !i_Container.IsDisposed)
            {
                colorSingleControl(i_Container, i_AppTheme);

                foreach (Control control in i_Container.Controls)
                {
                    ApplyTheme(control, i_AppTheme);
                }
            }
        }

        private static void colorSingleControl(Control i_Control, AppTheme i_AppTheme)
        {
            string tag = i_Control.Tag as string;

            // Color control only if it has a tag
            if (!string.IsNullOrEmpty(tag))
            {
                switch (tag)
                {
                    case "PrimaryBackground":
                        i_Control.BackColor = i_AppTheme.PrimaryBackColor;
                        break;

                    case "PanelBackground":
                        i_Control.BackColor = i_AppTheme.PanelBackColor;
                        break;

                    case "SecondaryPanel":
                        i_Control.BackColor = i_AppTheme.SecondaryPanelColor;
                        break;

                    case "Title":
                        i_Control.ForeColor = i_AppTheme.PrimaryTextColor;
                        break;

                    case "Subtitle":
                        i_Control.ForeColor = i_AppTheme.SecondaryTextColor;
                        break;
                }
            }
        }
    }
}
