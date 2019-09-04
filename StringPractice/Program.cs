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

            Console.WriteLine(firstName.ToLower() + " " + lastName.ToLower());

            Console.WriteLine("Which is longer - first or last");
            
            if(firstName.Length > lastName.Length)
            {
                Console.WriteLine("first");
            }
            if(firstName.Length < lastName.Length)
            {
                Console.WriteLine("last");
            }
            if (firstName.Length == lastName.Length)
            {
                Console.WriteLine("Your first and last name are equal in length");
            }
        }
    }
}
