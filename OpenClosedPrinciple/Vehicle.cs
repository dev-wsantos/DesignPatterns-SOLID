using OpenClosedPrinciple.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Vehicle : IVehicle
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public double Engine { get; set; }
       
        public Vehicle(string color, int year, double engine)
        {
            Color = color;
            Year = year;
            Engine = engine;
        }

        public void StartVehicle()
        {
            Console.WriteLine("Lingando o motor!");
        }
    }
}
