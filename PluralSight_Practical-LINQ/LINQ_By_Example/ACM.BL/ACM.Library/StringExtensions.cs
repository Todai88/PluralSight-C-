using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Library
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts a string to title case.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ConvertToTitlecase(this string source)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(source);
        }
    }
}
