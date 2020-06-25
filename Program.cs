using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine( "enter a number:" );
            int userInt = Int32.Parse(Console.ReadLine() );
            if ( userInt > 5 )
            {
                Console.WriteLine( " Greater than 5 but less than 11.");
            
            }
            else if ( userInt > 10 )
            {
                Console.WriteLine( " Greater than 10.");
            
            }
            else if ( userInt < 0 )
            {
                Console.WriteLine( " A negative number.");
            
            }
           else{
               Console.WriteLine(" Number is 1 and 4 ");
           }

          

        }

    }
}
