using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace H1_Stars_and_stripes_v2
{
    internal class Program
    {

        private static int[,] flagSize = new int[26, 38];
        private static int[,] flagBlueSize = new int[11, 23];
        static void Main()
        {
            bool flagColorWhite = true;

            //The vertical loop
            for (int i = 0; i < flagSize.GetLength(0); i++)
            {
                //Control if the color of the white red part of the flag needs to be white or not white
                if (i % 2 == 0)
                    flagColorWhite = !flagColorWhite;

                //The horizontal loop
                for (int j = 0; j < flagSize.GetLength(1); j++)
                {
                    //The control fot the flag is blue here and if there needs to be a star
                    if (j < flagBlueSize.GetLength(1) && i < flagBlueSize.GetLength(0))
                    {
                        int starOffset;
                        //Sets the backgrund to blue
                        Console.BackgroundColor = ConsoleColor.Blue;

                        //The controler for the offset of the stars
                        if ((i - 1) % 2 != 0)
                            starOffset = 3;
                        else
                            starOffset = 1;

                        //Control if there need to be a star
                        if ((j - starOffset) % 4 == 0 && i != 0 && i != 10)
                        {
                            Console.Write("*");
                            continue;
                        }
                    }
                    
                    else if (flagColorWhite)
                        Console.BackgroundColor = ConsoleColor.White;
                    else
                        Console.BackgroundColor = ConsoleColor.DarkRed;

                    //Write a space to color the backgrund 
                    Console.Write(" ");
                }
                //Next line of the flag
                Console.WriteLine("");
            }
            //stops the program from closing
            Console.ReadLine();
        }
    }
}
