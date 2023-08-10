using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Stars_and_stripes
{
    internal class Program
    {
        static void Main()
        {
            //The number that control the color of the white, red area 
            byte ColorControlNumber = 0;
            //Loop for the y-axis 
            for (int i = 0; i < 26; i++)
            {
                ColorControlNumber++;
                //The top part of the flag
                if (i < 11)
                { 
                    for (int j = 0; j < 38; j++)
                    {          
                        if (j <= 23)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(" ");
                        }
                        else
                        {
                            TitelColor(ColorControlNumber);
                        }
                    }                 
                }
                else
                {
                    for (int j = 0; j < 38; j++)
                        TitelColor(ColorControlNumber);
                }

                if (ColorControlNumber == 4)
                    ColorControlNumber = 0;

                //New line
                Console.WriteLine("");
            }

            AddStars();


            Console.ReadLine();



        }
        //This control if the backgrund is red or white 
        private static void TitelColor(byte ColorControlNumber)
        {
            if (ColorControlNumber <= 2)
                Console.BackgroundColor = ConsoleColor.Red;
            else if (ColorControlNumber <= 4)
                Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
        }

        //Adds the stars to the flag
       private static void AddStars()
        {
            byte moved = 0;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(1 + (j * 4 + moved), i);
                    Console.Write("*");
                }
                moved++;
                if (moved == 2)
                    moved = 0;
            }
        }
    }
}
