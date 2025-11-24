namespace Marqdouj.DotNet.Web.Components.FluentUI.UIInput
{
    /// <summary>
    /// Indicats where to display the selected color adjacent to the list.
    /// </summary>
    public enum UIInputColorPosition
    {
        None,
        Left,
        Right,
    }

    public class UIColorOptions : UIInputOptions
    {
        public UIInputColorPosition ColorPosition { get; set; } = UIInputColorPosition.Left;
        public SelectOptions SelectOptions { get; set; } = new();
    }
}
