using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm.Model
{
    internal class Worker
    {
        private string _name;
        private int _salary;
        
        private string _cpr;
        protected string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        protected int Salary
        {
            get { return _salary; }
            private set { _salary = value; }
        }

        protected string Cpr
        {
            get { return _cpr; }
            private set { _cpr = value; }
        }

        public Worker(string name, int salary, string cprNumber)
        {
            Name = name;
            Salary = salary;
            Cpr = cprNumber;

        }
        public override string ToString()
        {
            return "  Name: " + Name + "\n  Salary: " + Salary + "\n  CprNumber: " + Cpr;
        }
    }
}
