using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Robotterne_kommer
{
    public class Robot
    {
        private byte _type;

        private bool _hasWifi = false;

        private string _microchip;

        private Color _color = Color.White;

        private Battery _battery;

        private float _soapContainer;

        private byte _wheels;

        public Robot() :this((byte)1)
        {

        }
        public Robot(byte type)
        {
            _type = type;
            switch (type)
            {
                //cleaning windows robot
                case 2:
                    _microchip = "RX54667";
                    _soapContainer = 2.3f;
                    _wheels = 6;
                    break;
                //tire changing robot
                case 3:
                    _microchip = "QT8339";
                    _battery = new Battery();
                    _wheels = 8;
                    break;
                //Small robot / default robot
                default:
                    _type = 1;
                    _microchip = "";
                    _battery = new Battery();
                    _wheels = 0;
                    break;

            }
        }

        public Robot(byte type, bool hasWifi) : this(type)
        {
            _hasWifi = hasWifi;
        }
        /// <summary>
        /// Only need to be used if the color is not white
        /// </summary>
        /// <param name="type"></param>
        /// <param name="hasWifi"></param>
        /// <param name="color"></param>
        public Robot(byte type, bool hasWifi, Color color) : this(type, hasWifi)
        {
            _color = color;
            _battery = null;
        }

    }
}
