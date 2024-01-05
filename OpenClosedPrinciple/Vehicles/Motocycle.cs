using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Vehicles
{
    internal class Motocycle : Vehicle
    {
        public Motocycle(string color, int year, double engine) : base(color, year, engine)
        {
            Console.WriteLine($"Criando uma moto: {Color}, {Year}, {Engine} cilindradas.");
        }
    }
}
