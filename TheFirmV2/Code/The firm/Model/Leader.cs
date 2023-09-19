using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm.Model
{
    internal class Leader : Worker
    {
        private string _mobilnumber;

        private List<Worker> _workers = new List<Worker>();

        public List<Worker> Workers
        {
            get { return _workers; }
            set { _workers = value; }
        }
        protected string Mobilnumber
        {
            get { return _mobilnumber; }
            set { _mobilnumber = value; }
        }

        public Leader(string name, int salary, string cprNumber, string mobilnumber) : base(name,salary, cprNumber)
        {
            Mobilnumber = mobilnumber;
        }
        public override string ToString()
        {
            return base.ToString() + "\n  mobilnumber: " + Mobilnumber;
        }
    }
}
