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
    internal class Sweeper : Employee
    {
        public Sweeper(string firstName, string lastName, string cprNumber) : base(firstName, lastName, cprNumber) 
        {
            
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
