using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Payments
{
    internal class CreditCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Verificando o limite da conta.");
            Console.WriteLine("Limite Okay");
        }
    }
}
