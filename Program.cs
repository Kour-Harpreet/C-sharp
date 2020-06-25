using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //guide the user
            Console.WriteLine("please enter add/subtract/multiply/exit:");

            //collect the user input....
            string userInput;
            while ((userInput = Console.ReadLine()) != "exit") // LOOPS until user enters "exit" command.
            {
                int firstNum;
                int secondNum;
                int result;
                //Switch statements are similar to if/else.
                switch (userInput) // Here we enter the value we want to test.
                {// Cases are us testing the above against specific values.
                    case "add":
                        Console.WriteLine("Enter first number for addition:");
                        firstNum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number for addition:");
                        secondNum = Int32.Parse(Console.ReadLine());
                        result = firstNum + secondNum;
                        Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, result);

                        break;
                    case "subtract":
                        Console.WriteLine("Enter first number for subtraction:");
                        firstNum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number for subtraction:");
                        secondNum = Int32.Parse(Console.ReadLine());
                        result = firstNum - secondNum;
                        Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, result);
                        break;
                    case "multiply":
                        Console.WriteLine("Enter first number for multiplication:");
                        firstNum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number for multiplication:");
                        secondNum = Int32.Parse(Console.ReadLine());
                        result = firstNum * secondNum;
                        Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, result);

                        break;
                    default:
                        Console.WriteLine("Unrecognized operator/command entered.");
                        break;
                } // End of switch statement.
                Console.WriteLine("Please enter a new command: add/subtract/multiply/exit.");
            } // End of while statement.
        }

    }

}






