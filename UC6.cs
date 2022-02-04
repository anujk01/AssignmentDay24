using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay24
{
    class UC6
    {
        public static string PasswordRegex = "^(?=.*?[A-Z])[A-Za-z0-9]{8,}$";

        public bool ValidPassword(string password)
        {
            return Regex.IsMatch(password, PasswordRegex);
        }
    }
}
