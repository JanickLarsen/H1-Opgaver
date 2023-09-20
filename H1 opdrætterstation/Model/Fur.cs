using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_opdrætterstation.Model
{
    internal class Fur
    {
        private string _type;
        private short _length;
        private Color _color;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public short Length
        {
            get { return _length; }
            set { _length = value; }
        }
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public Fur(string type, short length, Color color)
        {
            _type = type;
            _length = length;
            _color = color;
        }
    }
}
