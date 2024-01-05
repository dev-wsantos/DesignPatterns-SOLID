using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Car : Vehicle
    {
        public int Seats { get; set; }
        public int Doors { get; set; }
        public Car(string color, int year, double engine, int seats, int doors) : base(color, year, engine)
        {

            Seats = seats;
            Doors = doors;

            ConfigureCar();

        }

        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro: {Color}, {Year}, {Engine}, {Doors} portas e {Seats} assentos.");
        }
    }
}
