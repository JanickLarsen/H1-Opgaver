using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm.Model
{
    internal class HR : CEO
    {
        public HR(string name, int salary, string cprNumber, string mobilnumber, string mail, bool hasCar) : base(name, salary, cprNumber, mobilnumber, mail, hasCar)
        {

        }
    }
}
