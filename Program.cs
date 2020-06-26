using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //2 dimensional array!
            string[,] topics = {{"cat"},{"dog"},{"frog"},{"hedgehog"},
                              {"zebra"},{"giragge"},{"lion"},{"elephants"},
                              {"dolphins"},{"octopus"},{"shark"},{"whale"},
                              {"ant"},{"beetle"},{"waterbug"},{"mosquito"}
                              };

            // Loop through the rows
            for (int row = 0; row < topics.GetLength(0); row++)
            {
                // Output current roe...
                Console.WriteLine(" starting column #{0}", row);
                // Loop through column in the current row....
                for (int column = 0; column < topics.GetLength(1); column++)
                {// output the current column...
                 
                    Console.WriteLine("starting column #{0}", column);
                    // output the current animal!
                    Console.WriteLine(" This animal is: {0}", topics[row, column]);

                }



            }

        }

    }
}






