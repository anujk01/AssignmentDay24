using System;

namespace AssignmentDay24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sample Email ");
            string emailSample = Console.ReadLine();
            UC9 EmailSampleRegex = new UC9();

            if (EmailSampleRegex.ClearEmailSample(emailSample))
                Console.WriteLine("Email is Correct");
            else
                Console.WriteLine("Email is Incorrect");
        }
    }
}
