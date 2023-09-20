using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_opdrætterstation.Model.Animals
{
    internal class Rabbit : Animal, IAnimal
    {
        public Rabbit(string sex, byte speed, string sound, bool laysEggs, bool mannal, short legs, Fur fur, short age) : base(sex, speed, sound, laysEggs, mannal, legs, fur, age)
        {

        }
        #region
        public override string print()
        {
            return "Rabbit";
        }
        void IAnimal.animalSound()
        {
            Console.WriteLine(Sound);
        }
        void IAnimal.walk()
        {
            Console.WriteLine("The Rabbit walks");
        }

        #endregion
    }
}
