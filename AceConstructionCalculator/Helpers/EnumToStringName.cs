using System;
using System.Globalization;
using AceConstructionCalculator.Enums;

namespace AceConstructionCalculator.Helpers
{
    public class EnumToStringName
    {
        public static string CategoryToTitle(Categories category)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
                category.ToString().ToLower().Replace("_", " "));
        }
    }
}
