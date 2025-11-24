using Marqdouj.DotNet.Web.Components.Css;
using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;

namespace Marqdouj.DotNet.Web.Components.FluentUI.UIInput
{
    /// <summary>
    /// <see href="https://www.fluentui-blazor.net/Tooltip"/>
    /// </summary>
    public class TooltipOptions
    {
        /// <summary>
        /// <see cref="FluentTooltip.Delay"/>
        /// </summary>
        public int? Delay { get; set; }

        [Parameter]
        public List<HtmlColorNameListItem>? Colors { get; set; }

        /// <summary>
        /// <see cref="FluentTooltip.MaxWidth"/>
        /// </summary>
        public string? MaxWidth { get; set; }

        /// <summary>
        /// <see cref="FluentTooltip.Position"/>
        /// </summary>
        public TooltipPosition? Position { get; set; }
    }
}
