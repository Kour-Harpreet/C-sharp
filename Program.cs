using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user.
            Console.WriteLine("please type: (add/subtract/exit)");
            string command; // Declare a variable.
            // Accept commands.
            while ((command = Console.ReadLine()) != "exit")
            {
                int result;
                if (command == "add")
                {
                    Console.WriteLine("Enter first number to add:");
                    int firstNum = CollectIntFromUser();
                    Console.WriteLine("Enter second number to add:");
                    int secondNum = CollectIntFromUser();
                    result = Addition(firstNum, secondNum);
                    Console.WriteLine("The result is: {0}", result);

                }
                else if (command == "subtract")
                {

                    Console.WriteLine("Enter first number to subtract:");
                    int firstNum = CollectIntFromUser();
                    Console.WriteLine("Enter second number to subtract:");
                    int secondNum = CollectIntFromUser();
                    result = Subtraction(firstNum, secondNum);
                    Console.WriteLine("The result is: {0}", result);
                }
                else
                {
                    Console.WriteLine("Invalid command, please try again");
                }
                Console.WriteLine("Please enter a command: (add/subtract/exit)");


            }//End of while loop...


        }
        static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        static int CollectIntFromUser()
        {
            int intValue = 0;

            bool error = true;
            while (error == true)
            {
                string userValue = Console.ReadLine();
                try // wrap potentially-failing code in a try - this will prevent an unhandled exception( fatal eror for your program)
                {
                     intValue = int.Parse(userValue);
                    error = false;

                }
                catch (Exception exception)
                { // we use "catch" to decide what happens if the  "try" has an error!
                    Console.WriteLine("invalid value entered. please enter a number");
                    Console.WriteLine(exception.Message); // The exceptionhas its own error meassage - helpful to know what is failing! 
                }
            }// End of the while loop
            return intValue; // ends execution of the method , and passes the value back
    }
        
    }

}






