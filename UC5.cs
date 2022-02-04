using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay24
{
    class UC5
    {
        public static string PasswordRegex = "^[a-z0-9]{8,}$";

        public bool ValidPassword(string password)
        {
            return Regex.IsMatch(password, PasswordRegex);
        }
    }
}
