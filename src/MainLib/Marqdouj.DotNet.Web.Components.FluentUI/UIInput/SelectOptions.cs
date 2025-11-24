using Microsoft.FluentUI.AspNetCore.Components;

namespace Marqdouj.DotNet.Web.Components.FluentUI.UIInput
{
    /// <summary>
    /// <see href="https://www.fluentui-blazor.net/Select"/>
    /// </summary>
    public class SelectOptions
    {
        /// <summary>
        /// <see cref="FluentSelect{TOption}.Appearance"/>
        /// </summary>
        public Appearance? Appearance { get; set; } = null;

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.AriaLabel"/>
        /// </summary>
        /// 
        public string? AriaLabel { get; set; }

        /// <summary>
        /// <see cref="FluentComponentBase.Class"/>
        /// </summary>
        public string? Class { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Disabled"/>
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// <see cref="ListComponentBase{TOption}.Height"/>
        /// </summary>
        public string? Height { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Placeholder"/>
        /// </summary>
        public string? Placeholder { get; set; }

        /// <summary>
        /// <see cref="FluentSelect{TOption}.Position"/>
        /// </summary>
        public SelectPosition Position { get; set; } = SelectPosition.Below;

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.ReadOnly"/>
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Required"/>
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// <see cref="FluentComponentBase.Style"/>"/>
        /// </summary>
        public string? Style { get; set; }

        /// <summary>
        /// <see cref="ListComponentBase{TOption}.Width"/>
        /// </summary>
        public string? Width { get; set; }
    }
}
