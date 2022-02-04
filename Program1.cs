using System;

namespace AssignmentDay24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            string name = Console.ReadLine();

            UC1 firstName = new UC1();

            if (firstName.ValidFirstName (name))
                Console.WriteLine("First Name is Correct");
            else
                Console.WriteLine("First Name is Incorrect");
        }
    }
}
