using Microsoft.FluentUI.AspNetCore.Components;
using Icons = Microsoft.FluentUI.AspNetCore.Components.Icons;

namespace Marqdouj.DotNet.Web.Components.FluentUI.UIInput
{
    public class UIInputOptions
    {
        public int? HorizontalGap { get; set; }
        public Icon Icon { get; set; } = new Icons.Regular.Size16.Info();
        public Orientation Orientation { get; set; } = Orientation.Vertical;
        public bool ShowTooltip { get; set; } = true;
        public bool ShowLabel { get; set; } = true;
        public TooltipOptions? TooltipOptions { get; set; }
        public int? VerticalGap { get; set; } = 3;
    }
}
