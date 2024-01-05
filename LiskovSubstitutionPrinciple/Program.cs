using LiskovSubstitutionPrinciple.Payments;
using System;


namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        /**
         *  Liskov Substitution Principle - Princípio da Substituição de Liskov
         *  
         *  As classes derivadas devem ser substituíveis por suas classes bases.
         */

        static void Main(string[] args)
        {

            NubankRewards card = new NubankRewards();

            card.Validate();
            card.CollectPayment();

            Console.ReadKey();
        }
    }
}
