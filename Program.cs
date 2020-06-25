using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Always tell user what to do
            Console.WriteLine( " Please tell us if you want to add or subtract: (add/subtract/multiply)");
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
            else if ( userOperator == "subtract" )
            {
                Console.WriteLine(" Please enter the first number to subtract: ");
                
                //https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
               
                int firstNum = Int32.Parse( Console.ReadLine()); // Convert to integer.
                
                Console.WriteLine(" Please enter the second number to subtract: ");
                int secondNum = Int32.Parse( Console.ReadLine());

                int result = firstNum - secondNum;
                Console.WriteLine( "{0} - {1} = {2}", firstNum, secondNum, result );
            }
            else if ( userOperator == "multiply" )
            {
                Console.WriteLine(" Please enter the first number to multiply: ");
                
                //https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
               
                int firstNum = Int32.Parse( Console.ReadLine()); // Convert to integer.
                
                Console.WriteLine(" Please enter the second number to multiply: ");
                int secondNum = Int32.Parse( Console.ReadLine());

                int result = firstNum * secondNum;
                Console.WriteLine( "{0} * {1} = {2}", firstNum, secondNum, result );
            }
             else
             {
                 Console.WriteLine( " Invalid operator entered." );
             }
          

        }

    }
}
