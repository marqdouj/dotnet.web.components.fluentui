using Microsoft.FluentUI.AspNetCore.Components;
using Icons = Microsoft.FluentUI.AspNetCore.Components.Icons;

namespace Marqdouj.DotNet.Web.Components.FluentUI.Themes
{
    public enum ThemeSelectAligment
    {
        Horizontal, 
        Vertical
    }

    public class ThemeSelectOptions
    {
        public string? ColorLabel { get; set; } = "Color";
        public Icon ColorIcon { get; set; } = new Icons.Filled.Size20.RectangleLandscape();
        public string? ColorHeight { get; set; } = "200px";
        public string? ColorStyle { get; set; }
        public string? ColorWidth { get; set; } = "200px";
        public DesignThemeModes Mode { get; set; }
        public OfficeColor? OfficeColor { get; set; }
        public string? StorageName { get; set; } = "theme";
        public string? ThemeLabel { get; set; } = "Theme";
        public string? ThemeStyle { get; set; }
        public string? ThemeWidth { get; set; } = "200px";
    }
}
