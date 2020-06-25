using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine( " Please tell us if you want to add or subtract: (add/subtract)");
            string userOperator = Console.ReadLine();

            if( userOperator == "add")
            {
                Console.WriteLine(" Please enter the first number: ");
                
                //https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
               
                int firstNum = Int32.Parse( Console.ReadLine()); // Convert to integer.
                
                Console.WriteLine(" Please enter the second number: ");
                int secondNum = Int32.Parse( Console.ReadLine());

                int result = firstNum + secondNum;
                Console.WriteLine( "{0} + {1} = {2}", firstNum, secondNum, result );

            }
          

        }

    }
}
