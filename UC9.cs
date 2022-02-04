using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay24
{
    class UC9
    {
        public static string SampleEmailRegex= "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";

        public bool ClearEmailSample(string sampleEmail)
        {
            return Regex.IsMatch(sampleEmail, SampleEmailRegex); ;
        }
    }
}