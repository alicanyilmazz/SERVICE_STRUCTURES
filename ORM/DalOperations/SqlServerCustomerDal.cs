using ORM.Entities;
using ORM.IDalOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DalOperations
{
    public class SqlServerCustomerDal : ICustomerDal
    {
        public Response Add(Customer Entity)
        {
            Console.WriteLine($"SqlServer : {Entity.Name} added.");
        }

        public Response Delete(Customer Entity)
        {
            Console.WriteLine($"SqlServer : {Entity.Name} deleted.");
        }

        public Response Update(Customer Entity)
        {
            Console.WriteLine($"SqlServer : {Entity.Name} deleted.");
        }
    }
}
