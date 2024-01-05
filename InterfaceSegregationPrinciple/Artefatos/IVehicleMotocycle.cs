using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Artefatos
{
    interface IVehicleMotocycle : IVehicle
    {
        void ConfigureMotocycle(string color, int year, double engine);
    }
}
