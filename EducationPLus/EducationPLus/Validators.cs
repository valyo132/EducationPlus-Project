using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EducationPLus
{
    public static class Validators
    {
        public static string Name { get; set; }
        public static string Username { get; set; }
        public static string NewOrderName { get; set; }

        public static bool IsEmailValid(string value)
        {
            string pattern = @"[a-zA-Z0-9]+@[a-z]+.[a-z]+";

            if (Regex.IsMatch(value, pattern))
                return true;

            return false;
        }
    }
}
