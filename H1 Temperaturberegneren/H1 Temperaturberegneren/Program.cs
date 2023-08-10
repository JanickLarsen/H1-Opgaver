using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Temperaturberegneren
{
    internal class Program
    {
        static void Main()
        {
            int Celsius = 0;
            

            //A control to see if the number the user has put into the console is valid
            try
            {
                //Gets the users number from the console
                Celsius = Convert.ToInt32(Console.ReadLine());
            }
            //Informain and reset the program
            catch
            {
                Console.Clear();
                Console.WriteLine("Skriv et nummer");
                Console.ReadLine();
                Console.Clear();
                Main();
            }
                
            

            //calculation for Fahrenheit and Reaumu from Celsius
            float Fahrenheit = (Celsius * 1.8f) + 32;
            float Reaumu = Celsius * 0.8f;

            //Write the calculations to the console
            Console.WriteLine(Fahrenheit + " Fahrenheit");
            Console.WriteLine(Reaumu + " Reaumu");


            //Stops the program from stopping 
            Console.ReadLine();

            //Resets program
            Console.Clear();
            Main();

        }
    }
}
