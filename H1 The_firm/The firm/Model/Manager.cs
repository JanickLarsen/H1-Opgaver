using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm
{
    /// <summary>
    /// 
    /// </summary>
    internal class Manager : Employee
    {
        private string _mobilNumber;

        protected string MobilNumber
        { 
            get { return _mobilNumber; }
            set { _mobilNumber = value; }
        }

        public Manager(string firstName, string lastName, string cprNumber, string mobilnumber) : base (firstName, lastName, cprNumber)
        {
            _mobilNumber = mobilnumber;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + _mobilNumber;
        }
    }
}
