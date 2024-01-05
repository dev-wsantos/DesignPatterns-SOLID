using OpenClosedPrinciple.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    /**
     *  Open Closed Principle (Princípio  Aberto / Fechado)
     *  
     *  Uma classe, com os seus atributos e métodos deve estar fechada para modificações/alterações
     *  e aberta para extensão.
     *  
     *  Não se deve alterar aquilo que já está implementado e é utlizado por outras classes do sistema
     *  porém, a esta classe pode sofrer a necessidade de extensão, adicionando novos recursos pertinentes
     *  à regra de negócio.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.MOTOCYCLE;

            if (type == TypeVehicle.CAR)
            {
                Vehicle car = new Car("Azul", 2022, 2.0, 5, 4);
                car.StartVehicle();
 
            }
            else
            {
                Motocycle moto = new Motocycle("Branca", 2000, 1.3);
                moto.StartVehicle();
            }

            Console.ReadKey();
        }
    }
}
