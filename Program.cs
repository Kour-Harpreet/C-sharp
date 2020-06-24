using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // two slashes is to begin single line comment
            // we are assigning string value to a variable
            string myName="Harpreet Kour";
            /* we begin multi line comment with forward slash and asterisk


            + symbol which we are using is to concatenate two strings together.

            ....and we end multi-line comments with asterisk followed by a forward slash */
            Console.WriteLine("Hello, " + myName);

            Console.WriteLine("Please enter your name..");

            // Assign variable 'username' to a value entered by the user.
            string userName = Console.ReadLine();
            // show the user we colect the name.
            Console.WriteLine("you have entered: "+userName);
            //Instead of traditional concatenation using the addition
            //We can use string interpolation (placeholders) to embed values in a string.
            Console.WriteLine("Hey {0}, you're looking great today!", userName);
        }
    }
}
