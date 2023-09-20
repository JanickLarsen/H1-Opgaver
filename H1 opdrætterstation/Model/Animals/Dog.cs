using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_opdrætterstation.Model.Animals
{
    internal class Dog : Animal, IAnimal
    {



        public Dog(string sex, byte speed, string sound, bool laysEggs, bool mannal, short legs, Fur fur, short age) : base(sex, speed, sound, laysEggs, mannal, legs, fur, age)
        {

        }
        #region
        public override string print()
        {
            return "Dog";
        }

        void IAnimal.animalSound()
        {
            Console.WriteLine(Sound);
        }


        void IAnimal.walk()
        {
            Console.WriteLine("The dog walk's");
        }

        #endregion

    }
}
