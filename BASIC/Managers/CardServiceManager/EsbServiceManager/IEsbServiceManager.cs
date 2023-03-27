using EsbService.Entities.Common;
using EsbService.Entities.NonCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC.Managers.CardServiceManager.EsbServiceManager
{
    public interface IEsbServiceManager : ICardServiceManager
    {
        public CardValidationResponse ValidateDebitCardRequest(CardValidationRequest request);
        public DoCashWithDrawalResponse DoCash(DoCashWithDrawalRequest request);
    }
}
