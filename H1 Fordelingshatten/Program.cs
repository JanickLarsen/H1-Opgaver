using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Fordelingshatten
{
    internal class Program
    {
        static void Main()
        {
            SortingHat sortingHat = new SortingHat();
            while (true) {               
                Console.WriteLine(sortingHat.GetCollege());
                Console.ReadLine();
            }
        }
    }
}
