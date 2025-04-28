using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persoon.Data
{
    internal static class Validator
    {
        public static string Title { get; set; }

        public static bool IsPresent(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsValidEmail(string text)
        {
            if (text.Contains('@') && text.Contains('.'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
