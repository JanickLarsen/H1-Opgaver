using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_opdrætterstation.Model
{
    internal abstract class Animal
    {
        #region
        private string _sex;
        private byte _speed;
        private string _sound;
        private bool _laysEggs;
        private bool _mammal;
        private short _legs;
        private Fur _fur;
        private short _age;

        protected string Sex
        {
            get {  return _sex; }
            private set { _sex = value; }
        }
        protected byte Speed
        {
            get { return _speed; }
            private set { _speed = value; }
        }
        protected string Sound
        {
            get { return _sound; }
            private set { _sound = value; }
        }
        protected bool LaysEggs
        {
            get { return _laysEggs; }
            private set { _laysEggs = value; }
        }
        protected bool Mannal
        {
            get { return _mammal; }
            private set { _mammal = value; }
        }
        protected short Legs
        {
            get { return _legs; }
            private set { _legs = value; }
        }
        protected Fur Fur
        {
            get { return _fur; }
            private set { _fur = value; }
        }
        protected short Age
        {
            get { return _age; }
            private set { _age = value; }
        }
        #endregion
        #region
        private Animal(string sex)
        {
            _sex = sex;
        }
        private Animal(string sex, byte speed) : this(sex)
        {
            _speed = speed;
        }
        private Animal(string sex, byte speed, string sound) : this(sex,speed)
        {
            _sound = sound;
        }
        private Animal(string sex, byte speed, string sound, bool laysEggs) : this(sex,speed,sound)
        {
            _laysEggs = laysEggs;
        }
        private Animal(string sex, byte speed, string sound, bool laysEggs, bool mannal) : this(sex,speed,sound, laysEggs)
        {
            _mammal = mannal;
        }
        private Animal(string sex, byte speed, string sound, bool laysEggs, bool mannal, short legs) : this(sex, speed,sound, laysEggs, mannal)
        {
            _legs = legs;
        }
        private Animal(string sex, byte speed, string sound, bool laysEggs, bool mannal, short legs, Fur fur) : this(sex,speed, sound,laysEggs, mannal,legs)
        {
            _fur = fur;
        }
        protected Animal(string sex, byte speed, string sound, bool laysEggs,bool mannal,short legs,Fur fur, short age) : this(sex,speed,sound, laysEggs, mannal, legs, fur)
        {
            _age = age;
        }
        #endregion

        public abstract string print();
        
    }
}
