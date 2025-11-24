using Microsoft.FluentUI.AspNetCore.Components;

namespace Marqdouj.DotNet.Web.Components.FluentUI.Common
{
    /// <summary>
    /// FluentButton Settings
    /// </summary>
    public class ButtonSettings
    {
        /// <summary>
        /// <see cref="FluentButton.Appearance"/>
        /// </summary>
        public Appearance? Appearance { get; set; }

        /// <summary>
        /// <see cref="FluentButton.Disabled"/>
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// <see cref="FluentButton.IconEnd"/>
        /// </summary>
        public Icon? IconEnd { get; set; }

        /// <summary>
        /// <see cref="FluentButton.IconStart"/>
        /// </summary>
        public Icon? IconStart { get; set; }

        /// <summary>
        /// <see cref="FluentButton.Title"/>
        /// </summary>
        public string? Title { get; set; }
    }
}
