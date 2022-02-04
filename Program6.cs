using System;

namespace AssignmentDay24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Password ");
            string password = Console.ReadLine();
            UC6 passwordRegex = new UC6();

            if (passwordRegex.ValidPassword(password))
                Console.WriteLine("Password is Correct");
            else
                Console.WriteLine("Password is Incorrect");
        }
    }
}
