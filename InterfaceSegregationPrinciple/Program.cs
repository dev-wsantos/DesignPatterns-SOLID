

using InterfaceSegregationPrinciple.Artefatos;
using System;

namespace InterfaceSegregationPrinciple
{

    /**
     * Interface Segregation Principle - Princípio da Segregação da Interface
     *  
     *  Quando as interfaces estão "infladas", se faz necessário criar interfaces mais resumidas/especificas.
     *  Os clientes não devem ser forçados a depender de métodos que eles não utilizam
     */

    class Program
    {
        static void Main(string[] args)
        {

            Car carro = new Car("Azul", 2022, 4.0, 2, 2);
            Motocycle moto = new Motocycle("Branca", 2023, 4.0d);
            Console.ReadKey();
        }
    }
}
