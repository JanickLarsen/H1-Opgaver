using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm
{
    internal class Program
    {
        static void Main()
        {
            Sweeper sweeper = new Sweeper("Janick", "larsen", "123456789");
            Projectmanager projectmanager = new Projectmanager("Janick", "larsen", "123456789", "22648886", "janickElev@gmail.com");
            Manager manager = new Manager("Janick", "larsen", "123456789", "22648886");
            

            Console.WriteLine(projectmanager.ToString());
            Console.WriteLine();
            Console.WriteLine(manager.ToString());
            Console.WriteLine();
            Console.WriteLine(sweeper.ToString());


            Console.ReadLine();


        }
    }
}
