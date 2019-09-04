using System;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name");

            string firstName;
            firstName = Console.ReadLine();

            Console.WriteLine("Your name is: " + firstName);

            Console.WriteLine("What is your last name");

            string lastName = Console.ReadLine();

            Console.WriteLine("Your last name is: " + lastName);

        }
    }
}
