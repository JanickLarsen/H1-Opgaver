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
            int[] lotterynumbers = new int[7];
            
            Random rng = new Random();
            //loop for the lottery numbers
            for (int i = 0; i < 7; i++)
            {
                int newNumber = rng.Next(1, 37);
                //Control for the number is taken
                while (lotterynumbers.Contains(newNumber))
                {
                    newNumber = rng.Next(1, 37);
                }
                //Save the number
                lotterynumbers[i] = newNumber;
            }            

            Array.Sort(lotterynumbers);
            //write the number to the user
            for (int i = 0; i < lotterynumbers.Length; i++)
            {               
                Console.Write(lotterynumbers[i] + " ");
                //Set the Thread to sleep for 2 seconds
                Thread.Sleep(2000);
            }

            int jokerNumber = rng.Next(1, 37);
            //Joker number is red
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(jokerNumber);

            //Stops the program from stopping
            Console.ReadLine();
        }
    }
}
