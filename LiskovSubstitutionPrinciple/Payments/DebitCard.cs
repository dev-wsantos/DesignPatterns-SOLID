﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Payments
{
    internal class DebitCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Verificando o saldo da conta");
            Console.WriteLine("Saldo disponível");
        }
    }
}