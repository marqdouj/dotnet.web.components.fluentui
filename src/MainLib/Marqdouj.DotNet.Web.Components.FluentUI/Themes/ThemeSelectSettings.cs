namespace Marqdouj.DotNet.Web.Components.FluentUI.Themes
{
    public enum ThemeSelectAligment
    {
        Horizontal, 
        Vertical
    }

    public class ThemeSelectSettings(ThemeColorSettings? colorSettings = null, ThemeModeSettings? modeSettings = null)
    {
        public ThemeColorSettings ColorSettings { get; } = colorSettings ?? new();
        public ThemeModeSettings ModeSettings { get; } = modeSettings ?? new();
    }
}
