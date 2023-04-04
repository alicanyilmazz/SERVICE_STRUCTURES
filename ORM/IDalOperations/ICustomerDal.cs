using ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.IDalOperations
{
    public interface ICustomerDal
    {
        Response Add(Customer Entity);
        Response Update(Customer Entity);
        Response Delete(Customer Entity);
    }
}
