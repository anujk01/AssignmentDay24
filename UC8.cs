using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay24
{
    class UC8
    {
        public static string PasswordRegex = "^[A-Za-z0-9]*[*&^%$#@!]{1}[A-Za-z0-9]*$";

        public bool ValidPassword(string password)
        {
            return Regex.IsMatch(password, PasswordRegex);
        }
    }
}
