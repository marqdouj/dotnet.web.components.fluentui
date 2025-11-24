using Microsoft.FluentUI.AspNetCore.Components;

namespace Marqdouj.DotNet.Web.Components.FluentUI.UIInput
{
    public static class UIExtensions
    {
        /// <summary>
        /// Creates a list of options representing boolean values, 
        /// suitable for use in selection controls.
        /// </summary>
        /// <param name="addDefault">
        /// if true, insert a new item at index '0'.
        /// This is usually the case for nullable values.
        /// </param>
        /// <param name="defaultText">option text</param>
        /// <param name="defaultValue">options value</param>
        /// <returns></returns>
        public static List<Option<string?>> GetBoolLookup(bool addDefault, string defaultText = "", string defaultValue = "")
        {
            var values = new List<Option<string?>>
            {
                new() {Text = false.ToString(), Value = false.ToString()},
                new() {Text = true.ToString(), Value = true.ToString()},
            };

            if (addDefault)
            {
                values.Insert(0, new() { Text = defaultText, Value = defaultValue });
            }

            return values;
        }

        /// <summary>
        /// Creates a list of options representing the values of the specified enumeration type, 
        /// suitable for use in selection controls.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="addDefault">
        /// if true, insert a new item at index '0'.
        /// This is usually the case for nullable values.
        /// </param>
        /// <param name="defaultText">option text</param>
        /// <param name="defaultValue">options value</param>
        /// <returns></returns>
        public static List<Option<string>> GetEnumLookup<TEnum>(bool addDefault, string defaultText = "", string defaultValue = "") where TEnum : Enum
        {
            var values = Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => e.ToString());
            var selectOptions = values.Select(e => new Option<string> { Text = e.Replace("_", ""), Value = e }).ToList();

            if (addDefault)
                selectOptions.Insert(0, new () { Text = defaultText, Value = defaultValue });

            return selectOptions;
        }
    }
}
