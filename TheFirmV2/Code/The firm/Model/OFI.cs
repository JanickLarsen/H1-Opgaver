using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm.Model
{
    internal class OFI : Boss
    {
        private bool _hasCar;

        private List<Boss> _Boss = new List<Boss>();

        public List<Boss> Boss
        {
            get { return _Boss; }
            set { _Boss = value; }
        }
        protected bool HasCar
        {
            get { return _hasCar; }
            set { _hasCar = value; }
        }

        public OFI(string name, int salary, string cprNumber, string mobilnumber, string mail, bool hasCar) : base(name, salary, cprNumber, mobilnumber, mail)
        {
            _hasCar = hasCar;
        }
    }
}
