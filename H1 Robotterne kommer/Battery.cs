using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Robotterne_kommer
{
    public class Battery
    {
        private byte _batteryCapacity;

        public byte BatteryCapacity
        {
            get { return _batteryCapacity; }
            private set { _batteryCapacity = value; }
        }
        public Battery() 
        {
            Random rng = new Random();
            _batteryCapacity = (byte)rng.Next(0, 256);
        }
    }
}
