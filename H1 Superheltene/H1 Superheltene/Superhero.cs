using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Superheltene
{
    /// <summary>
    /// class <c>Superhero</c> models a Superhero's characteristics
    /// </summary>
    public class Superhero
    {
    #region Properties
        private string _superheroName = "";
        private string _name = "";
        private byte _age = 0;
        private string[] _abilities = { "" };
        private string[] _moralCode = { "" };
        private string[] _archenemys = { "" };
        private bool _mask = true;
    #endregion

    #region Encapsulation
        public string SuperheroName 
        { 
            get { return _superheroName; }
            private set { _superheroName = value; } 
        }
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public byte Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string[] Abilities
        {
            get { return _abilities; }
            private set { _abilities = value; }
        }
        public string[] MoralCode
        {
            get { return _moralCode; }
            private set { _moralCode = value; }
        }
        public string[] Archenemys
        {
            get { return _archenemys; }
            private set { _archenemys = value; }
        }
        public bool Mask
        {
            get { return _mask; }
            private set { _mask = value; }
        }
    #endregion
    }
}
