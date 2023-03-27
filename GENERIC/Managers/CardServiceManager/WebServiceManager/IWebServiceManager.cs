using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC.Managers.CardServiceManager.WebServiceManager
{
    public interface IWebServiceManager<TRequest, TResponse> : ICardServiceManager<TRequest, TResponse>
    {

    }
}
