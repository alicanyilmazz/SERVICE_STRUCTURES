using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC.Managers.CardServiceManager
{
    public interface ICardServiceManager<TRequest, TResponse>
    {
        TResponse ValidateDebitCardRequest(TRequest request);
    }
}
