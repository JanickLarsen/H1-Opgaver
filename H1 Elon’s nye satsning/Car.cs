using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace H1_Elon_s_nye_satsning
{
    /// <summary>
    /// Class <c>Car</c> is a model of a electric car.
    /// </summary>
    public class Car
    {
        #region Fields
        private const byte BATTERY_CAPACITY = 100;
        
        private byte _batteryPower = 100;
        private short _metersDriven = 0;
        private Color _color = System.Drawing.Color.Red;     
        #endregion

        #region Encapsulation
        public byte BatteryPower
        {
            get { return _batteryPower; }
            private set { _batteryPower = value; }
        }
        public Color Color 
        {
            get { return _color; }
            private set { _color = value; }
        }
        public short MetersDriven
        {
            get { return _metersDriven; }
            private set { _metersDriven = value; }
        }
        
        #endregion
        #region public methods
        /// <summary>
        /// Drive the car 20 meters / 1% battery if there is still battery 
        /// </summary>
        public void Drive()
        {
            if (_batteryPower > 0)
            {
                _batteryPower -= 1;
                _metersDriven += 20;
            }
        }
        /// <summary>
        /// Charge the car over 5 seconds 
        /// sets the meters driven to 0 
        /// </summary>
        public void Charge()
        {
            _batteryPower = BATTERY_CAPACITY;
            _metersDriven = 0;
            Console.WriteLine();
            Thread.Sleep(5000);

        }


        /// <summary>
        /// Set the color of the car if the color is "red", "grenn" or "yellow"
        /// </summary>
        /// <param name="carColor"></param>
        /// <returns></returns>
        public bool SetColor(Color carColor)
        {
            if (carColor == Color.Red || carColor == Color.Yellow || carColor == Color.Green)
            {
                _color = Color;              
                return true;
            }
            return false;
        }

        #endregion

    }
}
