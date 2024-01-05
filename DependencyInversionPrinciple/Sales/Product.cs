using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Sales
{
    internal abstract class Product
    {
        private DateTime expirationDate;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public DateTime ExpirationDate { get => expirationDate.Date; set => expirationDate = value; }
    }
}
