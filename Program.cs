using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        { 
            // it is  agood idea, for user experience, to prompt the user.
            //Guiding the user is great, as it tells them what is expected.
            
            Console.WriteLine("Please enter a string");
            string userInput = Console.ReadLine();// assignment; collecting data from user.

            //we can use "if" statements to check a condition.
            // if the "if" statement is true, its code block (marked by curly braces {} will execute.)

            if (userInput.Length > 0)
          {
              Console.WriteLine( "The user entered a value.");

          } // If there is an "else" statement proceeding an "if" , it will only execute if the " if statement " was false.
          else
          {
              Console.WriteLine( "The user did not enter a value.");
          }


          

        }

    }
}
