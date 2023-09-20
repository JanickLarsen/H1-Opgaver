using H1_opdrætterstation.Model.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using H1_opdrætterstation.Model;

namespace H1_opdrætterstation
{
    internal class Program
    {
        static void Main()
        {
            Random rng = new Random();
            LinkedList<Animal> animals = new LinkedList<Animal>();
            for (int i = 0; i < 4; i++)
            {
                animals.AddLast(new Dog("Hun", 10, "vov", false, true, 4, new Model.Fur("lehter", 15, Color.Black), (short)rng.Next(0, 15)));
                animals.AddLast(new Chicken("Hun", 5, "aaaaa", true, true, 4, new Model.Fur("lehter", 15, Color.White), (short)rng.Next(0, 7)));
                animals.AddLast(new Rabbit("han", 25, "rav", false, true, 4, new Model.Fur("lehter", 15, Color.Brown), (short)rng.Next(0, 10)));
            }
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.print());
            }
            
        }
    }
}
