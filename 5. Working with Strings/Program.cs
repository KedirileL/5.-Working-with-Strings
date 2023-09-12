using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will be on one line. \n");
            Console.WriteLine("Skies are blue \n roses are red \n i love u \n");
            Console.WriteLine("Hi, my name is \"Lekgale\"");

            //declarations
            string firstName = "Lekgale";
            string lastName = "Ledwaba";
            Console.WriteLine(firstName + " " + lastName); // the + can be used to concatinate

            Console.WriteLine("The length of the name is " + firstName.Length); //function on string

            // Change name to uppercase, change last name lower case
            Console.WriteLine("\nName as upper case: " + firstName.ToUpper());
            Console.WriteLine("Last name as lower case: " + lastName.ToLower());

            // Checking what the letter on the names
            Console.WriteLine("Does firstname contain 'he': " + firstName.Contains("he"));
            Console.WriteLine("The first letter if the name is " + firstName[0]);
            Console.WriteLine("The index of r is " + firstName.IndexOf("k"));
            Console.WriteLine("The substring from 2 " + lastName.Substring(2));
            Console.WriteLine("The substring from 0 to 4 is " +lastName.Substring(0,4));

            //Freeze console
            Console.ReadLine();
        }
    }
}
