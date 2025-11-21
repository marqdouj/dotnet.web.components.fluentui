# DotNet.Web.Components.FluentUI

## Summary
C#  Components, classes, and extensions I find useful in my .NET FluentUI web-based projects.

## Demo
A demo of this, and other of my `DotNet` packages, can be found [here](https://github.com/marqdouj/dotnet.demo).

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

- **Models**
  - `GridItemOptions`. Provides configuration options for customizing a grid item.
    Useful for passing options to a component as a [Parameter].

## Release Notes
- `10.0.1`
  - Update NuGet packages.

- `10.0.0`
  - Initial release.
