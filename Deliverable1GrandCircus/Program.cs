using System;
using System.Linq;

namespace Deliverable1GrandCircus
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 7;
            int maxLength = 12;




            Console.Write("Please type in a password: ");
            string userPassword = Console.ReadLine();
            int stringLength = userPassword.Length;


            // need to know how many characters are in the string (how to find the length of a string)
            // will return int 
            // create variable to hold string length in
            // create if statement & compare length of string to minLength & maxLength ints





            if (stringLength >= minLength && (stringLength <= maxLength))
            {
                if (userPassword.Any(char.IsUpper) && userPassword.Any(char.IsLower) && userPassword.Any(char.IsPunctuation)
                )
                {
                    Console.WriteLine("Password valid & accepted.");
                }

            }
            else
            {
                Console.WriteLine("Error.");
            }

        }
    }
}
