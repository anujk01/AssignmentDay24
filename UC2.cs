using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay24
{
    internal class UC2
    {
        public string NameRegex = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidLastName(string lastname)
        {
            return Regex.IsMatch(lastname, NameRegex);
        }
    }
}

