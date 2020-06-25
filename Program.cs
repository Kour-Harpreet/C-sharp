using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        { 
            // logical operators
            // OR will evaluate to True if either side is True.

            Console.WriteLine( true  || true ); // true || is OR
            Console.WriteLine( false || true ); // true
            Console.WriteLine( false || false); // false


            // && will evaluate to True if only if BOTH side are True.
             

            Console.WriteLine( true  && true ); // TRUE. && is AND
            Console.WriteLine( false && true ); //false
            Console.WriteLine( false && false); //false

            // HOW DOES THIS BEHAVE WITH DIFFERENT DATA-TYPES?
            // Console.WriteLine( true && 1); // it DOESN'T!

            //Comparative operators...
            //"Equals to" check.
            Console.WriteLine( false == false ); //True
            Console.WriteLine( true  == false ); //False
            Console.WriteLine( 2.25  == 2.25  ); //True
            Console.WriteLine( 2.25  == 3.14  ); //False
            // Console.WriteLine( 3.14  = "3.14"  ); // Cannot check two different datatypes!


            // "Greater than" check.

            Console.WriteLine( 6 > 7 ); // False
            Console.WriteLine( 10 > 7 ); // True

            // "Less than" check.

            Console.WriteLine( 6 < 7 ); // true
            Console.WriteLine( 10 < 7 ); // False


            // "Greater -than-equal-to"  check.
            Console.WriteLine( 5 >= 5 );  // True
            Console.WriteLine( 10>= 5 );  // True
            Console.WriteLine( 4>= 5 );  // False

             // "Less-than-equal-to"  check.
             Console.WriteLine( 5 <= 5 );  // True
            Console.WriteLine( 10<= 5 );  // False
            Console.WriteLine( 4<= 5 );  // False







        }
    }
}
