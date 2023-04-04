using ORM.Entities;
using ORM.IDalOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DalOperations
{
    public class OracleCustomerDal : ICustomerDal
    {
        public Response Add(Customer Entity)
        {
            Console.WriteLine($"Oracle : {Entity.Name} added.");
        }

        public Response Delete(Customer Entity)
        {
            Console.WriteLine($"Oracle : {Entity.Name} deleted.");
        }

        public Response Update(Customer Entity)
        {
            Console.WriteLine($"Oracle : {Entity.Name} updated.");
        }
    }
}
