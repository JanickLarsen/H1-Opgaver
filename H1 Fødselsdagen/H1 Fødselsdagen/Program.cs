using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Fødselsdagen
{
    internal class Program
    {
        static void Main()
        {
            //Gives the user informanten for the syntax of the date 
            Console.WriteLine("Du kan skifte mønsteret ud til f.eks. dd-MM-yyyy");
            Console.WriteLine("Det indlæste fra brugeren skal følge mønsteret 01062008");
            
            //Convert the string to a DateTime
            DateTime birthday = DateTime.ParseExact(Console.ReadLine(), "ddMMyyyy", null);

            //Gets the difference in days
            DateTime now = DateTime.Now;
            TimeSpan difference = now - birthday;

            //uses a calculating to get the years in integer
            int years = (int)Math.Floor(difference.TotalDays / 365.2425);

            //uses a calculating to get the Days in integer 
            birthday = birthday.AddYears(years);
            difference = now - birthday;
            int days = (int)Math.Floor(difference.TotalDays);

            //Show the result to the user
            Console.Clear();
            Console.WriteLine("Du er " + years + " år og " + days + " dage gammel");

            //Stops the program
            Console.ReadLine();
        }
    }
}
