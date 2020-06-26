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
                              {"dolphins"},{"octopus"},{"shark"},{"whale"}};
            // we can use a oreach to iterate through the list of lists, one list at a time.

            foreach (string topic in topics)
            {// output the current animal!
                Console.WriteLine("this animal is: {0}", topic);

            }



        }

    }

}






