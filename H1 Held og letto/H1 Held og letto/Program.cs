using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H1_Held_og_letto
{
    internal class Program
    {
        static void Main()
        {
            Random rng = new Random();
            //loop for the lottery numbers
            for (int i = 0; i < 8; i++)
            {
                //Joker number is red
                if(i == 7)
                    Console.ForegroundColor = ConsoleColor.Red;

                //write the number to the user
                Console.Write(rng.Next(1,37) + " ");

                //Set the Thread to sleep for 2 seconds
                Thread.Sleep(2000);
            }

            //Stops the program from stopping
            Console.ReadLine();
        }
    }
}
