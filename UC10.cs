using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay24
{
    public class UC10
    {
        private string message;
        public UC10(string message)
        {
            this.message = message;
        }

        public string FirstName()
        {
            if (this.message.Contains("Happy"))
                return "Entry for First Name Successfull";
            else
                return "Entry for First Name UnSuccessfull";
        }

        public string LastName()
        {
            if (this.message.Contains("Happy"))
                return "Entry for Last Name Successfull";
            else
                return "Entry for Last Name UnSuccessfull";
        }

        public string Email()
        {
            if (this.message.Contains("Happy"))
                return "Entry for Email Successfull";
            else
                return "Entry for Email UnSuccessfull";
        }

        public string MobileNumber()
        {
            if (this.message.Contains("Happy"))
                return "Entry for Mobile Number Successfull";
            else
                return "Entry for Mobile Number UnSuccessfull";
        }

        public string Password()
        {
            if (this.message.Contains("Happy"))
                return "Entry for Password Successfull";
            else
                return "Entry for Password UnSuccessfull";
        }
    }
}