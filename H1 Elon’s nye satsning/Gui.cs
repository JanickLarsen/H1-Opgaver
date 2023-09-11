using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Elon_s_nye_satsning.View
{
    public class Gui
    {
        /// <summary>
        /// Display the cars battery and meters Driven to a cleard console
        /// </summary>
        public static void Display(Car car)
        {
            Console.Clear();
            Console.WriteLine("Battery = " + car.BatteryPower + "%");
            Console.WriteLine("Driven = " + car.MetersDriven + " Meters");
        }
        /// <summary>
        /// Text for if the car gets a wrong color
        /// </summary>
        public static void NotAColor()
        {
            Console.WriteLine("!!Not a valid color!!");
        }
        /// <summary>
        /// Text for the user for a new car
        /// </summary>
        public static void MakeNewCar()
        {
            Console.WriteLine("Press [Enter] to make new car");
        }
        /// <summary>
        /// Text for the car while Chargeing
        /// </summary>
        public static void ChargeingCar()
        {
            Console.WriteLine("Chargeing car. please wait");
        }
    }
}
