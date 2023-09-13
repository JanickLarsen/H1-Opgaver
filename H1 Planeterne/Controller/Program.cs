using H1_Planeterne.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Planeterne
{
    internal class Program
    {
        static void Main()
        {
            //part 2
            List<Planet> list = new List<Planet>
            {
                new Planet("Merkur", 0.330f, 4879, 5427, 3.7f, 1407.6f, 4222.6f, 57.9, 88.0f, 47.4f, 167, 0, false),
                new Planet("Jorden", 5.97f, 12756, 5514, 9.8f, 23.9f, 24.0f, 149.6, 365.2f, 29.8f, 15, 1, false),
                new Planet("Mars", 0.642f, 6792, 3933, 3.7f, 24.6f, 24.7f, 227.9, 687.0f, 24.1f, -65, 2, false),
                new Planet("Jupiter", 1898f, 142984, 1326, 23.1f, 9.9f, 9.9f, 778.6f, 4331, 13.1f, -110, 67, true),
                new Planet("Saturn", 568f, 120536, 687, 9.0f, 10.7f, 10.7f, 1433.5, 10747f, 9.7f, -140, 62, true),
                new Planet("Uranus", 86.8f, 51118, 1271, 8.7f, -17.2f, 17.2f, 2872.5, 30589f, 6.8f, -195, 27, true),
                new Planet("Neptun", 102f, 49528, 1638, 11.0f, 16.1f, 16.1f, 4495.1, 59.8f, 5.4f, -200, 14, true),
                new Planet("Pluto", 0.0146f, 2370, 2095, 0.7f, -153.3f, 153.3f, 5906.4, 90.56f, 4.7f, -255, 5, false)
            };

            Gui.DisplayPlanetName(list);

            //part 4
            list.Insert(1, new Planet("Venus", 4.87f, 12104, 5243, 8.9f, -5832.5f, 2802.0f, 108.2, 224.7f, 35.0f, 464, 0, false));

            //part 5
            Gui.DisplayPlanetName(list);

            //part 6
            foreach (Planet planet in list)
            {
                if (planet.Name == "Pluto")
                {
                    list.Remove(planet);
                    break;
                }                   
            }
            Gui.DisplayPlanetName(list);
            //part 7
            list.Add(new Planet("Pluto", 0.0146f, 2370, 2095, 0.7f, -153.3f, 153.3f, 5906.4, 90.56f, 4.7f, -255, 5, false));

            //part 8
            Console.WriteLine(list.Count());

            //part 9
            List<Planet> listMean = new List<Planet>();
            foreach (Planet planet in list)
            {
                if (planet.MeanTemperatur < 0)
                {
                    listMean.Add(planet);
                }
            }
            Gui.DisplayPlanetName(listMean);

            //part 10
            List<Planet> listDiameter = new List<Planet>();
            foreach (Planet planet in list)
            {
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                {
                    listDiameter.Add(planet);
                }
            }

            Gui.DisplayPlanetName(listDiameter);

            //part 11
            list.Clear();
            listMean.Clear();
            listDiameter.Clear();
        }

    }
}
