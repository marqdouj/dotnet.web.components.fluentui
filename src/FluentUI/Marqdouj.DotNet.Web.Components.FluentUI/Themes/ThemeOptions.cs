using Microsoft.FluentUI.AspNetCore.Components;
using Icons = Microsoft.FluentUI.AspNetCore.Components.Icons;

namespace Marqdouj.DotNet.Web.Components.FluentUI.Themes
{
    public class ThemeOptions
    {
        public string? AriaLabel { get; set; }
        public OfficeColor? Color { get; set; } = OfficeColor.Default;
        public Icon ColorIcon { get; set; } = new Icons.Filled.Size20.RectangleLandscape();
        public string? Height { get; set; } = "200px";
        public string? Label { get; set; }
        public DesignThemeModes Mode { get; set; } = DesignThemeModes.System;
        public string StorageName { get; set; } = "theme";
        public string? Width { get; set; } = "200px";
    }
}
