using Marqdouj.DotNet.General;
using Microsoft.FluentUI.AspNetCore.Components;

namespace Marqdouj.DotNet.Web.Components.FluentUI.Themes
{
    public class DesignThemeSettings : StateModel
    {
        #region Mode
        private DesignThemeModes mode;
        /// <summary>
        /// <see cref="FluentDesignTheme.Mode"/>
        /// </summary>
        public DesignThemeModes Mode { get => mode; set => SetValue(ref mode, value); }
        #endregion

        #region OfficeColor
        private OfficeColor? officeColor;
        /// <summary>
        /// <see cref="FluentDesignTheme.OfficeColor"/>
        /// </summary>
        public OfficeColor? OfficeColor { get => officeColor; set => SetValue(ref officeColor, value); }
        #endregion

        #region StorageName
        private string? storageName = "theme";
        /// <summary>
        /// <see cref="FluentDesignTheme.StorageName"/>
        /// </summary>
        public string? StorageName { get => storageName; set => SetValue(ref storageName, value); }
        #endregion

        /// <summary>
        /// Toggle the Mode between Light/Dark.
        /// </summary>
        public void ToggleTheme()
        {
            switch (Mode)
            {
                case DesignThemeModes.Dark:
                case DesignThemeModes.Light:
                    Mode = Mode == DesignThemeModes.Dark ? DesignThemeModes.Light : DesignThemeModes.Dark;
                    break;
                default:
                    var isDark = ThemeDetector.IsDarkModeEnabled();
                    Mode = isDark ? DesignThemeModes.Light : DesignThemeModes.Dark;
                    break;
            }
        }
    }
}
