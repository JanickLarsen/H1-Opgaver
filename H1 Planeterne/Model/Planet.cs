using H1_Planeterne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Planeterne
{
    /// <summary>
    /// part 1 of the work
    /// </summary>
    public class Planet
    {
        private string _name;

        private float _mass;

        private int _density;

        private int _diameter;

        private float _gravity;

        private float _rotationPeriod;

        private float _lengthOfDay;

        private double _distanceFromSun;

        private float _orbitalPeriod;

        private float _orbitalValoCity;

        private short _meanTemperatur;

        private byte _numberOfMoons;

        private bool _hasRingSystem;


        public string Name
        {
            get { return _name; }
            private set { _name = value; }

        }

        public float Mass
        {
            get { return _mass; }
            private set { _mass = value; }  
        }
        public int Density
        {
            get { return _density; }
            private set { _density = value; }
        }

        public short MeanTemperatur
        {
            get { return _meanTemperatur; }
            private set { _meanTemperatur = value; }

        }
        public int Diameter
        {
            get { return _diameter; }
            private set { _diameter = value; }
        }

        private Planet()
        {

        }
        private Planet(string name) : this()
        {
            _name = name;
        }
        private Planet(string name, float mass) : this(name)
        {
            _mass = mass;
        }
        private Planet(string name, float mass, int diameter) : this(name, mass)
        {
            _diameter = diameter;
        }
        private Planet(string name, float mass, int diameter, int density) : this(name, mass, density)
        {
            _density = density;
        }

        private Planet(string name, float mass, int diameter, int density, float gravity) : this(name, mass, density, diameter)
        {
            _gravity = gravity;
        }
        private Planet(string name, float mass, int diameter, int density, float gravity, float rotationPeriod) : this(name, mass,diameter, density,  gravity)
        {
            _rotationPeriod = rotationPeriod;
        }
        private Planet(string name, float mass, int diameter, int density, float gravity, float rotationPeriod, float lengthOfDay) : this(name, mass,diameter, density,  gravity, rotationPeriod)
        {
            _lengthOfDay = lengthOfDay;
        }
        private Planet(string name, float mass, int diameter, int density, float gravity, float rotationPeriod, float lengthOfDay, double distanceFromSun) : this(name, mass,diameter, density,  gravity, rotationPeriod, lengthOfDay)
        {
            _distanceFromSun = distanceFromSun;
        }
        private Planet(string name, float mass, int diameter, int density, float gravity, float rotationPeriod, float lengthOfDay, double distanceFromSun, float orbitalValoCity) : this(name, mass,diameter, density,  gravity, rotationPeriod, lengthOfDay, distanceFromSun)
        {
            _orbitalValoCity = orbitalValoCity;
        }
        private Planet(string name, float mass, int diameter, int density, float gravity, float rotationPeriod, float lengthOfDay, double distanceFromSun, float orbitalValoCity, float orbitalPeriod) : this(name, mass,diameter, density,  gravity, rotationPeriod, lengthOfDay, distanceFromSun)
        {
            _orbitalPeriod = orbitalPeriod;
        }
        private Planet(string name, float mass, int diameter, int density, float gravity, float rotationPeriod, float lengthOfDay, double distanceFromSun, float orbitalValoCity, float orbitalPeriod, short meanTemperatur) : this(name, mass,diameter, density,  gravity, rotationPeriod, lengthOfDay, distanceFromSun, orbitalValoCity, orbitalPeriod)
        {
            _meanTemperatur = meanTemperatur;
        }

        private Planet(string name, float mass, int diameter, int density, float gravity, float rotationPeriod, float lengthOfDay, double distanceFromSun, float orbitalValoCity, float orbitalPeriod, short meanTemperatur, byte numberOfMoons) : this(name, mass,diameter, density,  gravity, rotationPeriod, lengthOfDay, distanceFromSun, orbitalValoCity, orbitalPeriod, meanTemperatur)
        {
            _numberOfMoons = numberOfMoons;
        }
        public Planet(string name, float mass, int diameter, int density, float gravity, float rotationPeriod, float lengthOfDay, double distanceFromSun, float orbitalValoCity, float orbitalPeriod, short meanTemperatur, byte numberOfMoons, bool hasRingSystem) : this(name, mass,diameter, density,  gravity, rotationPeriod, lengthOfDay, distanceFromSun, orbitalValoCity, orbitalPeriod, meanTemperatur, numberOfMoons)
        {
            _hasRingSystem = hasRingSystem;
        }

        public override string ToString()
        {
            return "Planeten " + _name + " Har en mass på " + _mass + " og en diameter på " + _diameter;
        }

    }
}
