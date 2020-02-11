using SCommerce.Application.Interfaces.OC;
using SCommerce.Domain.Entities.OC;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.OC;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.OC
{
    public class OCHistoricoAppService : AppServiceBase<OCHistorico>, IOCHistoricoAppService
    {
        public OCHistoricoAppService(IServiceBase<OCHistorico> serviceBase) : base(serviceBase)
        {
        }
    }
}
