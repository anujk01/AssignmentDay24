using System;

namespace AssignmentDay24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile Number ");
            string mobileNumber = Console.ReadLine();
            UC4 mobileRegex = new UC4();

            if (mobileRegex.ValidMobileNumber(mobileNumber))
                Console.WriteLine("Number is Correct");
            else
                Console.WriteLine("Number is Incorrect");
        }
    }
}
