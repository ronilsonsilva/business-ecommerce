using SCommerce.Application.Interfaces.OC;
using SCommerce.Domain.Entities.OC;
using SCommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.OC
{
    public class OCStatusAppService : AppServiceBase<OCStatus>, IOCAppStatusService
    {
        public OCStatusAppService(IServiceBase<OCStatus> serviceBase) : base(serviceBase)
        {
        }
    }
}
