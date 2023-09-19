using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm.Model
{
    internal class Boss : Leader
    {

        private string _mail;

        private List<Leader> _leaders = new List<Leader>();

        public List<Leader> Leaders
        {
            get { return _leaders; }
            set { _leaders = value; }
        }

        protected string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public Boss(string name, int salary, string cprNumber, string mobilnumber, string mail) : base(name, salary, cprNumber, mobilnumber)
        {
            Mail = mail;
        }
        public override string ToString()
        {
            return base.ToString() + "\n  mail: " + Mail;
        }
    }
}
