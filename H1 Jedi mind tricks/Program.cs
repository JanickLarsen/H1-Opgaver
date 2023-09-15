using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Jedi_mind_tricks
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> people = new Dictionary<string, int>()
            {
                { "Luke", 1 },
                { "Han", 2 },
                { "Chewbacca", 3 },
            };
            people.Remove("Han");
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
