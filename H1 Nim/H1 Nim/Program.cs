using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace H1_Nim
{
    internal class Program
    {
        static void Main()
        {
            int matches = 7;
            bool pcTurn = false;
            while (matches > 0)
            {

                Console.Clear();
                //Info to the user
                Console.WriteLine("Hver spiller skiftes til at tage 1,2 eller 3 pinde op fra bordet.");
                Console.WriteLine("Der er lige nu " + matches + " tændstikker");

                //The pc controller
                if (pcTurn)
                {
                    if (matches > 4)
                        matches -= 2;
                    else
                        matches--;
                    //Makes the thread to sllep so the pc use time to play
                    Thread.Sleep(1000);
                }
                else
                {
                    //Gets the user input
                    int Userinput = Convert.ToInt32(Console.ReadLine());
                    if (Userinput - matches > 1)
                    {
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    if (Userinput > 1 && Userinput < 4)
                    {
                        matches -= Userinput;
                    }
                }
                //controle for lost
                if (matches == 1)
                {
                    continue;
                }

                pcTurn = !pcTurn;
            }
            //info for the user in the console
            if (pcTurn)
            {
                Console.WriteLine("Du vandt");
            }
            else
            {
                Console.WriteLine("Pc vandt");
            }

            //stops the program from closing
            Console.ReadLine() ;
        }
    }
}
