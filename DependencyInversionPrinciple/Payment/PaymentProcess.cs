using DependencyInversionPrinciple.Factory;
using DependencyInversionPrinciple.Interfaces;
using InterfaceSegregationPrinciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Payment
{
    class PaymentProcess
    {
        public void Pay(int id)
        {
            IDbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);

            Console.WriteLine(productData);
        }
    }
}
