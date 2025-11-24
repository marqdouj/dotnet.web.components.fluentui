namespace Marqdouj.DotNet.Web.Components.FluentUI.Themes
{
    internal static class ThemeDetector
    {
        public static bool IsDarkModeEnabled()
        {
            if (OperatingSystem.IsWindows())
            {
                const string registryKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
                const string valueName = "AppsUseLightTheme";

                object? registryValue = Microsoft.Win32.Registry.GetValue(registryKey, valueName, null);

                if (registryValue is int themeValue)
                {
                    // 0 means Dark Mode, 1 means Light Mode
                    return themeValue == 0;
                }
            }

            // Default to Light Mode if the value is not found
            return false;
        }
    }
}
