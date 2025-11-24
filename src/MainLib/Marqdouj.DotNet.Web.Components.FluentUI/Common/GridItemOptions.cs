using Microsoft.FluentUI.AspNetCore.Components;

namespace Marqdouj.DotNet.Web.Components.FluentUI.Common
{
    /// <summary>
    /// Provides configuration options for customizing a grid item.
    /// <example>
    /// Expose this class as a [Parameter] for use with internal GridItem components.
    /// <code>
    /// FluentGridItem
    ///     Gap="@options.Gap"
    ///     HiddenWhen="@options.HiddenWhen"
    ///     Justify="@options.Justify"
    ///     Style="@options.Style"
    ///     lg="@options.Lg" 
    ///     md="@options.Md" 
    ///     sm="@options.Sm" 
    ///     xl="@options.Xl" 
    ///     xs="@options.Xs" 
    ///     xxl="@options.Xxl"
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>Use this class to specify layout behaviors such as spacing, conditional visibility, content
    /// justification, and responsive column spans for individual grid items. Properties correspond to grid item
    /// attributes for various screen sizes and layout scenarios. All properties are optional; unset properties will use
    /// default grid behavior.</remarks>
    public class GridItemOptions
    {
        /// <summary>
        /// Gets or sets the gap value used to separate elements or define spacing within the layout.
        /// <see cref="FluentGridItem.Gap"/>
        /// </summary>
        public string? Gap { get; set; }

        /// <summary>
        /// Gets or sets the condition that determines when the grid item is hidden.
        /// <see cref="FluentGridItem.HiddenWhen"/>
        /// </summary>
        /// <remarks>Use this property to specify criteria under which the grid item should not be
        /// displayed. If the value is <see langword="null"/>, the item is always visible.</remarks>
        public GridItemHidden? HiddenWhen { get; set; }

        /// <summary>
        /// Gets or sets the justification strategy for aligning content within the container.
        /// <see cref="FluentGridItem.Justify"/>
        /// </summary>
        /// <remarks>Set this property to specify how child elements are distributed along the main axis.
        /// If the value is <see langword="null"/>, the default justification behavior is applied.</remarks>
        public JustifyContent? Justify { get; set; }

        /// <summary>
        /// Optional in-line styles.
        /// <see cref="FluentComponentBase.Style"/>
        /// </summary>
        public string? Style { get; set; }

        /// <summary>
        /// The number of columns the item should span in the 12-column grid system.
        /// <see cref="FluentGridItem.lg"/>
        /// </summary>
        public int? Lg { get; set; }

        /// <summary>
        /// The number of columns the item should span in the 12-column grid system.
        /// <see cref="FluentGridItem.md"/>
        /// </summary>
        public int? Md { get; set; }

        /// <summary>
        /// The number of columns the item should span in the 12-column grid system.
        /// <see cref="FluentGridItem.sm"/>
        /// </summary>
        public int? Sm { get; set; }

        /// <summary>
        /// The number of columns the item should span in the 12-column grid system.
        /// <see cref="FluentGridItem.xl"/>
        /// </summary>
        public int? Xl { get; set; }

        /// <summary>
        /// The number of columns the item should span in the 12-column grid system.
        /// <see cref="FluentGridItem.xs"/>
        /// </summary>
        public int? Xs { get; set; }

        /// <summary>
        /// The number of columns the item should span in the 12-column grid system.
        /// <see cref="FluentGridItem.xxl"/>
        /// </summary>
        public int? Xxl { get; set; }
    }
}
