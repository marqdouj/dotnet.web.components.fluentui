using Marqdouj.DotNet.General.Extensions;
using Microsoft.FluentUI.AspNetCore.Components;

namespace Marqdouj.DotNet.Web.Components.FluentUI.Extensions
{
    /// <summary>
    /// ToastService helpers for errors.
    /// </summary>
    public static class ToastExtensions
    {
        public static void Success(this IToastService service, string message) => service.ShowToast(ToastIntent.Success, message);
        public static void Warning(this IToastService service, string message) => service.ShowToast(ToastIntent.Warning, message);
        public static void Error(this IToastService service, string message) => service.ShowToast(ToastIntent.Error, message);
        public static void Error(this IToastService service, Exception exception) => service.ShowToast(ToastIntent.Error, exception.ToMessage());
        public static void Info(this IToastService service, string message) => service.ShowToast(ToastIntent.Info, message);
    }
}
