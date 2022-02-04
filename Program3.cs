using System;

namespace AssignmentDay24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Email ");
            string email = Console.ReadLine();
            UC3 emailRegex = new UC3();

            if (emailRegex.ValidEmail(email))
                Console.WriteLine("Email is Correct");
            else
                Console.WriteLine("Email is Incorrect");
        }
    }
}
