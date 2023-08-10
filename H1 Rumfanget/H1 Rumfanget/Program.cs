using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Rumfanget
{
    internal class Program
    {
        static void Main()
        {
            //Gets the written height
            Console.WriteLine("højde");
            double height = (ToNumber(Console.ReadLine()));
            Console.Clear();

            //Gets the written width
            Console.WriteLine("bredde");
            double width = (ToNumber(Console.ReadLine()));
            Console.Clear();

            //Gets the written length
            Console.WriteLine("længde");
            double length = (ToNumber(Console.ReadLine()));
            Console.Clear();


            //writes the volume of the box
            Console.WriteLine("Rumfanget er = " + (height * width * length));

            //Stops the program
            Console.ReadLine();
        }


        
        private static double ToNumber(string NumberString)
        {
            //Controls if the written number can be convertet to a double
            try
            {
                return Convert.ToDouble(NumberString);
            }
            catch
            {
                Console.Clear();
                Console.Write("Blevet sat til 0 det du ikke har skrevet et nummer");
                Console.ReadLine();
                Console.Clear();
                return 0;
            }

             
        }
    }
}
