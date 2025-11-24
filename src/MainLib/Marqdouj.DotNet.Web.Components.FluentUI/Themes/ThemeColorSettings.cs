using Marqdouj.DotNet.Web.Components.FluentUI.Common;
using Microsoft.FluentUI.AspNetCore.Components;
using Icons = Microsoft.FluentUI.AspNetCore.Components.Icons;

namespace Marqdouj.DotNet.Web.Components.FluentUI.Themes
{
    public class ThemeColorSettings : SelectSettings
    {
        public ThemeColorSettings()
        {
            Label = "Color";
            Height = "200px";
            Width = "200px";
        }

        public Icon Icon { get; set; } = new Icons.Filled.Size20.RectangleLandscape();
    }
}
