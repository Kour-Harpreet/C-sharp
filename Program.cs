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
            //https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=netcore-3.1

            Console.WriteLine("Hey {0}, you're looking great today!", userName);

            //let's play with string!
            Console.WriteLine( "makemeuppercase".ToUpper() );
            Console.WriteLine( "MAKEMELOWERCASE".ToLower() );
            // substring takes two arguments: 1) starting character position 2) Number of character to collect.
            Console.WriteLine( "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(3,3));
            Console.WriteLine( "XYZ".Length); // get the number of character for the string.



        }
    }
}
