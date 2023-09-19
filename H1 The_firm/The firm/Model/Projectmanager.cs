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
    internal class Projectmanager : Manager
    {
        private string _mailAdesse;

        protected string MailAdesse
        {
            get { return _mailAdesse; }
            set { _mailAdesse = value;}
        }

        public Projectmanager(string firstName, string lastName, string cprNumber, string mobilnumber, string mailAdesse) : base(firstName, lastName, cprNumber, mobilnumber)
        {
            _mailAdesse = mailAdesse;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + _mailAdesse;
        }
    }
}
