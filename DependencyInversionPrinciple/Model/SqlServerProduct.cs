using DependencyInversionPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Models
{
    public class SqlServerProduct : IDbProduct
    {
        public string GetProductById(int id)
        {
            return $"SQL Server: Exibindo dados do produto {id}";
        }
    }
}