using Microsoft.FluentUI.AspNetCore.Components;

namespace Marqdouj.DotNet.Web.Components.FluentUI.Common
{
    /// <summary>
    /// FluentSelect settings.
    /// </summary>
    public class SelectSettings
    {
        /// <summary>
        /// <see cref="FluentSelect{TOption}.Appearance"/>
        /// </summary>
        public Appearance? Appearance { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.AriaLabel"/>
        /// </summary>
        public string? AriaLabel { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Disabled"/>
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// <see cref="ListComponentBase{TOption}.Height"/>
        /// </summary>
        public string? Height { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Label"/>
        /// </summary>
        public string? Label { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Placeholder"/>
        /// </summary>
        public string? Placeholder { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.ReadOnly"/>
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Required"/>
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// <see cref="FluentComponentBase.Style"/>
        /// </summary>
        public string? Style { get; set; }

        /// <summary>
        /// <see cref="ListComponentBase{TOption}.Width"/>
        /// </summary>
        public string? Width { get; set; }

    }
}
