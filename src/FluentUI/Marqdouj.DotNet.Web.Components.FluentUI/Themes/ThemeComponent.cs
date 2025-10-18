namespace Marqdouj.DotNet.Web.Components.FluentUI.Themes
{
    public interface IThemeComponent
    {
        /// <summary>
        /// <see cref="ThemeSettings"/>
        /// </summary>
        DesignThemeSettings? ThemeSettings { get; set; }

        /// <summary>
        /// Flag to indicate that an external FluentDesignTheme component will be used.<br />
        /// If true, then the FluentDesignTheme component must be present elsewhere<br />
        /// and the ThemeSettings must bound to that component<br />
        /// and the ThemeSettings.StateChanged action set with StateHasChanged().<br />
        /// <example>
        /// Configure ThemeSettings for StateChanged.<br />
        /// <code>
        /// private readonly DesignThemeSettings themeSettings = new();
        /// protected override void OnInitialized()
        /// {
        ///     themeSettings.StateChanged += (string propertyName) =>
        ///     {
        ///          StateHasChanged();
        ///     }
        /// }
        /// </code>
        /// </example>
        /// </summary>
        bool ExternalDesignTheme { get; set; }
    }
}
