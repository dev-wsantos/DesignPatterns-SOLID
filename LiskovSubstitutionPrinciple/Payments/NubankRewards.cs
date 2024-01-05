using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Payments
{
    internal class NubankRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");
            Console.WriteLine("Pontuação creditada no Nubank Rewards!");
        }

        public void Validate()
        {
            Console.WriteLine("Limite Okay, Rewards Okay");
        }
    }
}
