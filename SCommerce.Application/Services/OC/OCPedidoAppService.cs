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
    public class OCPedidoAppService : AppServiceBase<OCPedido>, IOCPedidoAppService
    {
        public OCPedidoAppService(IServiceBase<OCPedido> serviceBase) : base(serviceBase)
        {
        }
    }
}
