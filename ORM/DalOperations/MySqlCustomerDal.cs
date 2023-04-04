using ORM.Entities;
using ORM.IDalOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DalOperations
{
    public class MySqlCustomerDal : ICustomerDal
    {
        public Response Add(Customer Entity)
        {
            Console.WriteLine($"MySql : {Entity.Name} added.");
        }

        public Response Delete(Customer Entity)
        {
            Console.WriteLine($"MySql : {Entity.Name} deleted.");
        }

        public Response Update(Customer Entity)
        {
            Console.WriteLine($"MySql : {Entity.Name} updated.");
        }
    }
}
