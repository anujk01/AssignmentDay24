using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay24
{
    class UC7
    {
        public static string PasswordRegex = "^(?=.*?[A-Z])(?=.*?[0-9])[A-Za-z0-9]{8,}$";

        public bool ValidPassword(string password)
        {
            return Regex.IsMatch(password, PasswordRegex);
        }
    }
}
