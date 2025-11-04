# DotNet.Web.Components.FluentUI

> NOTE: This is a new repository and is released as a Preview version.

## Summary
C#  Components, classes, and extensions I find useful in my .NET FluenUI web-based projects.

## Demo
A demo of all my `DotNet` packages can be found [here](https://github.com/marqdouj/dotnet.demo).

## Features

**Components**
- [**Themes**](https://www.fluentui-blazor.net/DesignTheme)
  - **`ThemeColor`**: Component for selecting theme color.
  - **`ThemeMode`**: Component for selecting between system, light, and dark themes.
  - **`ThemeToggle`**: Component for toggling between light/dark mode.
  - **`ThemeSelect`**: Combination of both ThemeMode and ThemeColor.
    Supports Horizontal or Vertical display.

- **UIInput**. Components for user input that support binding to [`IUIModelValue`](https://github.com/marqdouj/HtmlComponents/tree/master/src/Marqdouj.HtmlComponents/Marqdouj.HtmlComponents/UI).
  - `UIColor`: Select from a list of HtmlColors (list of items is customizable).
  - `UISelect`: Select a value from a list (list of items is customizable).
  - `UIText`: Supports string, double, int32, and int64 binding.
  - `UIValuesGrid`: Displays the UIModel values as a grid.

## Release Notes
- `10.0.0-rc-2.2`
  - `UIInput`.
    - `UIColor`. Default colors are now based on the new `Model.IsNullable` property
      instead of `Model.IsNullableValueType`; which fixes the issue where a default (null) value
      was not being added to the list, even if the underlying string property was nullable.
  - Update NuGet packages.

- `10.0.0-rc-2.1`
  - `UIInput`.
    - `UIColor`. Changed default values: height:250px width:200px
    - `UISelect`. Changed default values: height:250px width:200px
  - Update NuGet packages.

- `10.0.0-rc-2.0`
  - Update NuGet packages.

- `10.0.0-rc-1.2.1`
  - `UIValuesGrid`. Removed debug console write in OnParametersSet.

- `10.0.0-rc-1.2`
  - `UIValuesGrid`.
    - `TableTemplateColums` (New) . Space delimited string of valid Css column widths to apply when in Table display mode,
       e.g. "100px 1fr 2fr".

- `10.0.0-rc-1.1`
  - `UIValuesGrid`.
    - `DisplayMode`.  Added missing [Parameter] tag.
    - `ResizableColumns`.  Added missing [Parameter] tag.
    - `DisplayModeEmpty`. New parameter. The DisplayMode to use when there are no items. Depending on your settings
       the header might display in the middle of the grid when there are no items.

- `10.0.0-rc-1.0`
  - `UIValuesGrid`. Refactored.
    - Added `OnRowClicked` event callback.
    - Added `OnRowDoubleClicked` event callback.
    - Added `OnRowFocused` event callback.
    - Exposed many grid properties as parameters.
      - `DisplayMode`. Defaults to `Table` (was `Grid`).
      - `GenerateHeader`. Defaults to `Sticky`.
      - `ResizableColumns`. Defaults to `true`.
      - `ResizeType`. Defaults to `Discrete`.
      - `ShowHover`. Defaults to `false`.
      - `ValueProperty`. Defaults to `Raw` (was `Formatted`).
    - `GridTemplateColumns`. Only applies when `DisplayMode` is `Grid`.
 
- `10.0.0-Preview8.1`
  - `UIValuesGrid`. Added `EmptyContent` parameter. Updated Xml comments.
 
- `10.0.0-Preview8.0` (Breaking Changes)
  - `Themes`.
    - All Theme components and settings have been refactored.
    - If you were only using defaults previously then you shouldn't notice the difference.

- `10.0.0-Preview7.1`
  - `Themes`.
    - `ThemeSelect`. Added missing check for FluentDesignTheme flag.

- `10.0.0-Preview7.0` (Breaking Changes)
  - `ThemeSelect`. Renamed `ThemeSelectOptions` to `ThemeSelectSettings`.

- `10.0.0-Preview6.1`
  - Update NuGet packages.
 
- `10.0.0-Preview6.0` (Breaking Changes)
  - `Themes`.
    - `ThemeToggle`. 
      - Renamed `ThemeSwitch` to `ThemeToggle`. The name better
      represents what the control actually does.
      - Previous Parameters now part of 'Settings`.
  - `XMLComments`. Comments are now distributed with the package.

- `10.0.0-Preview4.1`
  - `Themes`.
    - `ThemeSwitch`. Added 'Windows' check for system theme.

- `10.0.0-Preview4`
  - `Themes`.
    - `ThemeSelect`. New component. Combination of both ThemeMode and ThemeColor.
    - `ThemeSwitch`. Modifcations to improve functionality.

- `10.0.0-Preview2.2.1`
  - `Themes`. Added StateHasChanged notification.

- `10.0.0-Preview2.2`
  - `Themes`. Modifications to the ThemeSwitch component.

- `10.0.0-Preview2.1`
  - `Themes`. Moved theme controls into their own namespace.

- `10.0.0-Preview2`
  - `ToastExtensions`. Helper extension methods for
  Success, Warning, Error, and Info.

- `10.0.0-Preview`
  - Initial release.
