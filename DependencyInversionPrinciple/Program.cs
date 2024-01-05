using System;

using DependencyInversionPrinciple.Payment;

namespace DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dependency Inversion Principle
             *  
             *  Um módulo de alto nível não pode depender de um módulo de baixo nível: Ambos precisam depender apenas de 
             *  abstrações. E as abstrações não devem depender dos detalhes: Os detalhes é que devem depender das abstrações.
             */

            PaymentProcess payment = new PaymentProcess();
            payment.Pay(93403);

            Console.ReadKey();
        }
    }
}
