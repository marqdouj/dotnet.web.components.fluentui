using Marqdouj.DotNet.Web.Components.UI;
using Microsoft.FluentUI.AspNetCore.Components;

namespace Marqdouj.DotNet.Web.Components.FluentUI.UIInput
{
    public static class UIExtensions
    {
        /// <summary>
        /// Converts <![CDATA[List<Option<string?>>]]> to <![CDATA[List<Option<string>>]]>.
        /// </summary>
        /// <remarks></remarks>
        /// <param name="values"></param>
        /// <returns></returns>
        public static List<Option<string>> ConvertToString(this List<Option<string?>> values)
        {
            return [.. values.Select(e => new Option<string>() { Text = e.Text, Value = e.Value })];
        }

        /// <summary>
        /// Helper method for <see cref="GetBoolLookup(bool, string, string)"/> that uses string instead of string?
        /// </summary>
        /// <param name="addDefault">If true, insert a new item at index '0'. This is usually the case for nullable values.</param>
        /// <param name="defaultText">Text if default option is added.</param>
        /// <param name="defaultValue">Value if default option is added.</param>
        /// <returns></returns>
        public static List<Option<string>> GetBoolLookups(bool addDefault, string defaultText = "", string defaultValue = "") =>
            [.. GetBoolLookup(addDefault, defaultText, defaultValue).Select(e => new Option<string>() { Text = e.Text, Value = e.Value })];

        /// <summary>
        /// Creates a list of options representing boolean values, suitable for use in selection controls.
        /// </summary>
        /// <param name="addDefault">If true, insert a new item at index '0'. This is usually the case for nullable values.</param>
        /// <param name="defaultText">Text if default option is added.</param>
        /// <param name="defaultValue">Value if default option is added.</param>
        /// <returns></returns>
        public static List<Option<string>> GetBoolLookup(bool addDefault, string defaultText = "", string defaultValue = "")
        {
            var values = new List<Option<string>>
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
        /// Creates a list of options representing the values of the specified enumeration type, suitable for use in selection controls.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="addDefault">If true, insert a new item at index '0'. This is usually the case for nullable values.</param>
        /// <param name="defaultText">Text if default option is added.</param>
        /// <param name="defaultValue">Value if default option is added.</param>
        /// <param name="underscoreReplacement">Replacement string for '_' in Enum name. Default is empty string.</param>
        /// <param name="useDisplayName">If <see langword="true"/> then the Display attribute name 
        /// will used (if available) for the Text. Default is <see langword="true"/></param>
        /// <returns></returns>
        public static List<Option<string>> GetEnumLookup<TEnum>(
            bool addDefault,
            string defaultText = "",
            string defaultValue = "",
            string underscoreReplacement = "",
            bool useDisplayName = true) where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .GetEnumLookup(addDefault, defaultText, defaultValue, underscoreReplacement, useDisplayName);
        }

        /// <summary>
        /// Creates a list of options representing the values of the specified enumeration type, suitable for use in selection controls.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="items"></param>
        /// <param name="addDefault">If true, insert a new item at index '0'. This is usually the case for nullable values.</param>
        /// <param name="defaultText">Text if default option is added.</param>
        /// <param name="defaultValue">Value if default option is added.</param>
        /// <param name="underscoreReplacement">Replacement string for '_' in Enum name. Default is empty string.</param>
        /// <param name="useDisplayName">If <see langword="true"/> then the Display attribute name 
        /// will used (if available) for the Text. Default is <see langword="true"/></param>
        /// <returns></returns>
        public static List<Option<string>> GetEnumLookup<TEnum>(
            this IEnumerable<TEnum> items,
            bool addDefault,
            string defaultText = "",
            string defaultValue = "",
            string underscoreReplacement = "",
            bool useDisplayName = true) where TEnum : Enum
        {
            var selectOptions = new List<Option<string>>();

            foreach (var enumValue in items)
            {
                var text = (useDisplayName ? enumValue.GetDisplayName() : enumValue.ToString())?.Replace("_", underscoreReplacement);
                var value = enumValue.ToString();
                var option = new Option<string>() { Text = text, Value = value };
                selectOptions.Add(option);
            }

            if (addDefault)
                selectOptions.Insert(0, new() { Text = defaultText, Value = defaultValue });

            return selectOptions;
        }
    }
}
