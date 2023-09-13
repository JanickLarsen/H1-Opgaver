using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Planeterne.View
{
    internal class Gui
    {

        public static void DisplayPlanetName(List<Planet> list)
        {
            Console.Clear();
            foreach (Planet planet in list)
            {
                Console.WriteLine(planet.Name);
            }
        }
    }
}
