using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.Entities.Common;

namespace BASIC.Managers.CardServiceManager.WebServiceManager
{
    public class WebServiceManager : IWebServiceManager
    {
        public CardValidationResponse ValidateDebitCardRequest(CardValidationRequest request)
        {
            Console.WriteLine("WebService.ValidateDebitCardRequest Called!");
            return default;
        }
    }
}
