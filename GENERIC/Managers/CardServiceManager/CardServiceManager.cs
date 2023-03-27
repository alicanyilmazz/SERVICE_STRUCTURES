using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC.Managers.CardServiceManager
{
    internal class CardServiceManager<TRequest, TResponse> where TRequest : class where TResponse : class
    {
        private static CardServiceManager<TRequest, TResponse> current = null;

        public static CardServiceManager<TRequest, TResponse> Current
        {
            get
            {
                current = current ?? new CardServiceManager<TRequest, TResponse>();
                return current;
            }
        }

        public TResponse ValidateDebitCardRequest(TRequest request, ICardServiceManager<TRequest, TResponse> serviceManager)
        {
            return serviceManager.ValidateDebitCardRequest(request);
        }
    }
}
