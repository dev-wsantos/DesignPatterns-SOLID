using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Model
{
    class MongoDBProduct : IDbProduct
    {
        public string GetProductById(int id)
        {
            return $"MongoDB: Exibindo dados do produto {id}";
        }
    }
}
