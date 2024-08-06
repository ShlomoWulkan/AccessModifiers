using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Vehicle
    {
        protected string model { get; set; }

        private string engineCapacity { get; set; }
    }

    internal class Car : Vehicle 
    {
        private int numberOfDoors { get; set; }

        public Car(string Model, int NumberOfDoors) 
        {
            numberOfDoors = NumberOfDoors;
            model = Model;
        }

        public Car GetCar()
        {
            return this;
        }
    }
}
