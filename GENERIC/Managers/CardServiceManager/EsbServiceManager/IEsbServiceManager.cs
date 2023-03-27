using EsbService.Entities.NonCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC.Managers.CardServiceManager.EsbServiceManager
{
    public interface IEsbServiceManager<TRequest, TResponse> : ICardServiceManager<TRequest, TResponse>
    {
        public DoCashWithDrawalResponse DoCashWithDrawal(DoCashWithDrawalRequest request);
        public TResponse DoPinChange(TRequest request);
    }
}
