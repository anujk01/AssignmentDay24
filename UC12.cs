using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay24
{
    public class UC12
    {
        public void CheckFirstName(string firstName)
        {
            if (obj.ValidFirstName(firstName))
                Console.WriteLine("Valid First Name !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "First Name is Invalid !!");
        }

        public void CheckLastName(string lastName)
        {
            if (Obj.ValidLastName(lastName))
                Console.WriteLine("Valid Last Name !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Last Name is Invalid !!");
        }

        public void CheckEmail(string email)
        {
            if (Obj.ValidEmail(email))
                Console.WriteLine("Valid Email !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Email is Invalid !!");
        }

        public void CheckMobile(string mobileNumber)
        {
            if (Obj.ValidMobile(mobileNumber))
                Console.WriteLine("Valid Mobile Number !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILENUMBER, "Mobile number is Invalid !!");
        }

        public void CheckPassword(string password)
        {
            if (Obj.ValidCondition1(password) && Obj.ValidCondition4(password))
                Console.WriteLine("Valid Password !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid !!");
        }
    }
}
