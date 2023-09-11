using H1_Elon_s_nye_satsning.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H1_Elon_s_nye_satsning.Controller
{
    public class Controller
    {
        #region public methods
        public void start() 
        {
            while (true) { 
                Color[] carColors = { Color.Red, Color.Yellow, Color.Green };
                for (int i = 0; i < 3; i++)
                {
                    MakeRemoteCar(carColors[i]);
                    Gui.MakeNewCar();
                    Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// Makes and starts the remote controled car
        /// </summary>
        /// <param name="Color"></param>
        public void MakeRemoteCar(Color Color)
        {
            Car car = new Car();
            //Is a valid car color
            if (car.SetColor(Color) == true)
            {
                //Test drive car
                TestDrive(car);
            }
            else
            {
                Gui.NotAColor();
            }
            //Wait on userinput to testdrive car2
        }

        /// <summary>
        /// Test drive the car to it hit 0 on the battery.
        /// Charges the car to full battery capacity
        /// </summary>
        /// <param name="car"></param>
        static void TestDrive(Car car)
        {
            while (car.BatteryPower > 0)
            {
                Thread.Sleep(200);
                car.Drive();
                Gui.Display(car);
            }
            Gui.ChargeingCar();
            car.Charge();
            Gui.Display(car);
        }
        #endregion
    }
}
