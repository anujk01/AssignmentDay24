using System;

namespace AssignmentDay24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Last Name");
            string name = Console.ReadLine();

            UC2 lastName = new UC2();

            if (lastName.ValidLastName(name))
               Console.WriteLine("Last Name is Correct");
            else
                Console.WriteLine("Last Name is Incorrect");

        }
    }
}
