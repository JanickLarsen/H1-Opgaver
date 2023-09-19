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
    internal class Employee
    {
        private string _firstName;
        private string _lastName;
        private string _cprNumber;

        protected string FirstName
        {
            get { return _firstName; } 
            set { _firstName = value; }
        }
        protected string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        protected string CprName
        {
            get { return _cprNumber; }
            set { _lastName = value; }
        }

        public Employee(string firstName, string lastName, string cprNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cprNumber = cprNumber;
        }

        public override string ToString()
        {
            return FirstName + "\n" + LastName + "\n" + CprName;
        }

    }
}
