using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class StringExtender
    {
        public static string ToCurrency(this string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentNullException("String cannot be null or empty.");

            if (str.All(char.IsDigit))
                return "$" + str;

            throw new ArgumentException("String must contain at least one digit.");
        }
    }
}
