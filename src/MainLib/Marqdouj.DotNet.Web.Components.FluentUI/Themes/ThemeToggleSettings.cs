using Marqdouj.DotNet.Web.Components.FluentUI.Common;
using Icons = Microsoft.FluentUI.AspNetCore.Components.Icons;

namespace Marqdouj.DotNet.Web.Components.FluentUI.Themes
{
    public class ThemeToggleSettings : ButtonSettings
    {
        public ThemeToggleSettings()
        {
            IconStart = new Icons.Regular.Size20.DarkTheme();
            Title = "Toggle Theme (Light/Dark)";
        }
    }
}
