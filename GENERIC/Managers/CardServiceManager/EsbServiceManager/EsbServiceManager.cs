using EsbService.Entities.NonCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC.Managers.CardServiceManager.EsbServiceManager
{
    public class EsbServiceManager<TRequest, TResponse> : IEsbServiceManager<TRequest, TResponse>
    {
        public TResponse ValidateDebitCardRequest(TRequest request)
        {
            Console.WriteLine("EsbService.ValidateDebitCardRequest Called!");
            return default;
        }

        public DoCashWithDrawalResponse DoCashWithDrawal(DoCashWithDrawalRequest request)
        {
            Console.WriteLine("EsbService.DoCash Called!");
            return default;
        }

        public TResponse DoPinChange(TRequest request)
        {
            Console.WriteLine("EsbService.DoPinChange Called!");
            return default;
        }
    }
}
