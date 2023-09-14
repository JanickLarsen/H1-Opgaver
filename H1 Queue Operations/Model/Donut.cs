using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Queue_Operations.Model
{
    public class Donut
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public Donut()
        {
            _name = "Chocolate Chip Specialé";  // This will be the default name (value).
        }

        public Donut(string Name) : this()
        {
            _name = Name;
        }

    }
}
