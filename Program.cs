using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        { 
            int myNum = 3;
            while ( myNum > 0  ) // Iteration/loops while the CONDITION is true.
            {

                Console.WriteLine( " Current number is {0}", myNum );
                myNum--;
            }

            /* For loops have 3 semi-colon-separated components:
            1) Assignment.
            2) [Termination] Condition.
            3) Iteration 
            */

            for( int i = 0; i < 6; i += 2 )
            {
                Console.WriteLine("Current (for) number is :{0}", i);

            }

            // If we need to iterate a list, use foreach!

            string[] myList = { "cat", "turtle", "lizard", "frog", "dog"};
            foreach ( string listItem in myList)
            {
                Console.WriteLine(" the current item is : {0}", listItem);
            }



            
          

        }

    }
}
