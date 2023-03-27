using BASIC.Managers.CardServiceManager.EsbServiceManager;
using BASIC.Managers.CardServiceManager.WebServiceManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC.Managers.CardServiceManager
{
    public class CardServiceManager : ICardServiceManager
    {
        private static CardServiceManager instance;
        public static CardServiceManager Instance
        {
            get
            {
                instance = instance ?? new CardServiceManager();
                return instance;
            }
        }
        public EsbService.Entities.Common.CardValidationResponse ValidateDebitCardRequest(EsbService.Entities.Common.CardValidationRequest request, IEsbServiceManager serviceManager)
        {
            return serviceManager.ValidateDebitCardRequest(request);
        }

        public WebService.Entities.Common.CardValidationResponse ValidateDebitCardRequest(WebService.Entities.Common.CardValidationRequest request, IWebServiceManager serviceManager)
        {
            return serviceManager.ValidateDebitCardRequest(request);
        }
    }
}
