using DependencyInversionPrinciple.Interfaces;
using DependencyInversionPrinciple.Model;
using InterfaceSegregationPrinciple.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Factory
{
    class DbProductFactory 
    {
        public static IDbProduct Create()
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SqlServerProduct();
            }
            else
            {
                return new MongoDBProduct();
            }
        }
    }
}
