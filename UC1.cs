using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay24
{
    internal class UC1
    {

        public string NameRegex = "^[A-Z]{1}[A-Za-z]{2,}$";

        public bool ValidFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, NameRegex);
        }
    }
}

