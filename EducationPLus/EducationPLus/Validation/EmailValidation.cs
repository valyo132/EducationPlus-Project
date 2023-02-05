using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EducationPLus.Validation
{
    public static class EmailValidation
    {
        public static bool IsEmailValid(string value)
        {
            string pattern = @"[a-zA-Z0-9]+@[a-z]+.[a-z]+";

            if (Regex.IsMatch(value, pattern))
                return true;

            return false;
        }
    }
}
