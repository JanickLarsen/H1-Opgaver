using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Juletræet_med_sin_pynt
{
    internal class Program
    {
        static void Main()
        {
            //the Christmas tree loop
            for (int i = 0; i < 8; i++)
                //making space before the star
            {
                for (int j = 0; j < + 8 - i; j++)
                    Console.Write(" ");

                //the line for the star
                for (int j = 0; j < 1 + (i * 2); j++)
                {
                    
                    //Control for the star to be green or red
                    if (j % 2 == 0)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.Red;
                    //Write the star to the console
                    Console.Write("*");
                }
                //Next line
                Console.WriteLine();
            }

            //stops the program from stopping
            Console.ReadLine();
        }
    }
}
