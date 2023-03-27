using EsbService.Entities.Common;
using EsbService.Entities.NonCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC.Managers.CardServiceManager.EsbServiceManager
{
    public class EsbServiceManager : IEsbServiceManager
    {
        public CardValidationResponse ValidateDebitCardRequest(CardValidationRequest request)
        {
            Console.WriteLine("EsbService.ValidateDebitCardRequest Called!");
            return default;
        }
        public DoCashWithDrawalResponse DoCash(DoCashWithDrawalRequest request)
        {
            Console.WriteLine("EsbService.DoCash Called!");
            return default;
        }
    }
}
