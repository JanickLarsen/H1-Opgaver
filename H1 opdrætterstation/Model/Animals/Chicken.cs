using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_opdrætterstation.Model.Animals
{
    internal class Chicken : Animal, IAnimal
    {


        public Chicken(string sex, byte speed, string sound, bool laysEggs, bool mannal, short legs, Fur fur, short age) : base(sex, speed, sound, laysEggs, mannal, legs, fur, age)
        { 

        }

        #region


        public override string print()
        {
            return "Chicken";
        }

        void IAnimal.animalSound()
        {
            Console.WriteLine(Sound);
        }

        void IAnimal.walk()
        {
            Console.WriteLine("The chicken walks");
        }

        #endregion
    }
}
