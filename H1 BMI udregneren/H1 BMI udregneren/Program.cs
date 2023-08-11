using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BMI_udregneren
{
    internal class Program
    {
        static void Main()
        {
            //Gets the user weight from the console
            Console.WriteLine("Skriv din vægt i kg (Kun tal)");
            double weight = IsNumber(Console.ReadLine());
            Console.Clear();

            //Gets the heigt of the user
            Console.WriteLine("Skriv din højte i cm (Kun tal)");
            double height = IsNumber(Console.ReadLine()) / 100;
            Console.Clear();

            //makse som math to get the BMi of the user
            double BMI = (weight / (height * height));


            //Show the BMI
            Console.WriteLine("Din BMI er = " + BMI);
            //Show the name of the BMI the user is in
            if (BMI < 18.5)
                Console.WriteLine("Body weigt deffict");

            else if (BMI < 24)
                Console.WriteLine("norm");

            else if (BMI < 30)
                Console.WriteLine("weight over");

            else if (BMI < 35)
                Console.WriteLine("obesity first degree");

            else if (BMI < 40)
                Console.WriteLine("obesity second degree");

            else
                Console.WriteLine("obesity third degree");

            //Stops the program from stopping
            Console.ReadLine();

        }



        static double IsNumber(string userInput)
        {
            //Controls if the input of the user can be convertet to a double
            try
            {
                return Convert.ToDouble(userInput);
            }
            catch
            {
                Console.WriteLine("Fejl");
                Console.ReadLine();
                Console.Clear();
                Main();
                return 0;
            }
        }
    }
}
