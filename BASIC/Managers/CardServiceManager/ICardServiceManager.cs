using BASIC.Managers.CardServiceManager.EsbServiceManager;
using BASIC.Managers.CardServiceManager.WebServiceManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC.Managers.CardServiceManager
{
    public interface ICardServiceManager
    {
        public EsbService.Entities.Common.CardValidationResponse ValidateDebitCardRequest(EsbService.Entities.Common.CardValidationRequest request, IEsbServiceManager serviceManager);
        public WebService.Entities.Common.CardValidationResponse ValidateDebitCardRequest(WebService.Entities.Common.CardValidationRequest request, IWebServiceManager serviceManager);

    }
}
