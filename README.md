# DotNet.Web.Components.FluentUI

> NOTE: This is a new repository and is released as a Preview version.

## Summary
C#  Components, classes, and extensions I find useful in my .NET FluenUI web-based projects.

## Demo
A demo of all my `DotNet` packages can be found [here](https://github.com/marqdouj/dotnet.demo).

## Features

**Components**
- [**Themes**](https://www.fluentui-blazor.net/DesignTheme)
  - **`ThemeSelect`**: Combination of both ThemeMode and ThemeColor.
    Supports Horizontal or Vertical display.
  - **`ThemeSwitch`**: Component for toggling between light and dark themes.
  - **`ThemeMode`**: Component for selecting between system, light, and dark themes.
  - **`ThemeColor`**: Component for selecting theme color.
  
- **UIInput**. Components for user input that support binding to [`IUIModelValue`](https://github.com/marqdouj/HtmlComponents/tree/master/src/Marqdouj.HtmlComponents/Marqdouj.HtmlComponents/UI).
  - `UIColor`: Select from a list of HtmlColors (list of items is customizable).
  - `UISelect`: Select a value from a list (list of items is customizable).
  - `UIText`: Supports string, double, int32, and int64 binding.
  - `UIValuesGrid`: Displays the UIModel values as a grid.

## Release Notes
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
