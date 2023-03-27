using GENERIC.Managers.CardServiceManager.EsbServiceManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC.Managers.CardServiceManager.WebServiceManager
{
    public class WebServiceManager<TRequest, TResponse> : IWebServiceManager<TRequest, TResponse>
    {
        public TResponse ValidateDebitCardRequest(TRequest request)
        {
            Console.WriteLine("WebService.ValidateDebitCardRequest Called!");
            return default;
        }
    }
}
