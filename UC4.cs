using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay24
{
    class UC4
    {
        public static string NumberRegex = "^[91]{1}[ ]{1}[6-9]{1}[0-9]{9}$";

        public bool ValidMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, NumberRegex);
        }
    }
}

