﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Payments
{
    internal interface IPaymentInstrument
    {
        void Validate();
        void CollectPayment();
    }
}
