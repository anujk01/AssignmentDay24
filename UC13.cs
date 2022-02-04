using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay24
{
    class UC13
    {
        public Func<string, bool> isValidFirstName = firstname => Regex.IsMatch(firstname, firstnameRegex);


        public Func<string, bool> isValidLastName = lastname => Regex.IsMatch(lastname, lastnameRegex);


        public Func<string, bool> isValidEmail = email => Regex.IsMatch(email, EmailRegex);


        public Func<string, bool> isValidMobileNumber = mobilenumber => Regex.IsMatch(mobilenumber, NumberRegex);


        public Func<string, bool> isValidPassword = password => Regex.IsMatch(password, PasswordRegex) && Regex.IsMatch(password, PasswordRegex);
    }
}
