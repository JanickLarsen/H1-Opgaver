using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Terningen
{
    internal class Program
    {
        static void Main()
        {
            
            Random rdn = new Random();
            while (true) { 
                //Gets a random number from 1 to 6
                int dice = rdn.Next(1,7);

                //Show the user how to roll the dice
                Console.WriteLine("Klick på en knap, for at slå med ternigen");
                Console.ReadLine();
                Console.Clear();

                //show the user the hit of the dice and a color for the hit
                if (dice == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("du slog 1");
                
                }
                else if (dice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("du slog 2");
               
                }
                else if (dice == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("du slog 3");
                    
                }
                else if (dice == 4)
                {                                      
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    Console.WriteLine("du slog 4");
                }
                else if (dice == 5)
                {                                      
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Console.WriteLine("du slog 5");
                }
                else
                {                  
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Clear();
                    Console.WriteLine("du slog 6");
                    
                }

                //Clear the console 
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
            }
        }
    }
}
