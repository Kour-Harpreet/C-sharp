using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {  
            // "=" is the assignment operator!
            //String datatype is used for text.
            string myString = " This is a string!";
            // Integer datatype is used for whole numbers (no decimals.)
            int myInt = 42;
            // double datatypes is used for decimal point numbers.
            double myDouble = 33.666;
            // Boolean datatype is used for TRUE/FALSE values - think binary!
            bool myBool = true;

            //Subtraction operator is "-"(minus.)
            Console.WriteLine( myInt - 10 ); //32


            //Multiplication operator is "*" (multiply)
            Console.WriteLine( myInt * 2); // 84


            //Division operator "/" (division)
            Console.WriteLine( myInt / 2); // 21

            //Modulus operator is % (percentage)
            Console.WriteLine( myInt % 13); //3

            //Addition operator is " + " (plus)
            //Wait ! this is also the concatenation operator.
            Console.WriteLine( myInt + 8); // 50



            Console.WriteLine("3" + "3"); // 33
            Console.WriteLine("3" + 3); // 33
            Console.WriteLine( 3 + "3"); // 33
            Console.WriteLine( 3 + 3); // 6
            Console.WriteLine( 9 + 3 + "3"); // 123


            //output our Variable
            Console.WriteLine( myInt );//42

            // A new assignment on an existing variable.
            myInt = myInt + 2; // 44
            Console.WriteLine( myInt );

            /*
            We cant turn myInt into a string! We told C# that myInt would always be an Int!
            
            myInt = myInt + "2"; // 44
            Console.WriteLine( myInt ); */

            myInt--; // tha same as typing myInt == myInt - 1;
            Console.WriteLine(myInt); // 43


            myInt += 4; // tha same as typing: myInt = myInt +3;
            Console.WriteLine(myInt); //47


             myInt -= 5; // tha same as typing: myInt = myInt -5;
            Console.WriteLine(myInt); //42

            




        }
    }
}
