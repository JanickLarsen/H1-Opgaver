using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Vinos_blancos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //start the contoller
            Controller();

            //Stops the porogram from closing
            Console.ReadLine();
        }
        #region Controller
        private static void Controller()
        {
            const int MAX = 175388 + 35432;
            const byte MAX_STAR = 100;
            int[] numberOfStars = new int[11];
            //loop to get the number of stars for the year
            for (int i = 0; i < VinosData().Length; i++)
            {
                numberOfStars[i] = MAX_STAR * VinosData()[i] / MAX;
            }
            //Sort the numbers
            Array.Sort(numberOfStars);
            Array.Reverse(numberOfStars);
            
            Drawgraph(numberOfStars);
        }
        #endregion

        #region Gui
        private static void Drawgraph(int[] starsToDraw)
        {
            //loop for a year
            for (int i = 0; i < starsToDraw.Length; i++)
            {
                //loop for stars
                for (int j = 0; j < starsToDraw[i]; j++)
                {
                    Console.Write("*");
                }   
                Console.WriteLine();
            }

           
        }
        #endregion

        #region Model
        private static int[] VinosData()
        {
            //From 2009 - 2019
            int[] vinos = { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 150979, 149450, 154398, 150160 };
            vinos[5] += 35432;
            return vinos;
        }
        #endregion
    }
}
