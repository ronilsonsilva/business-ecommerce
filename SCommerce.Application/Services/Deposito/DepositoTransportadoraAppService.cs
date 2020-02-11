using SCommerce.Application.Interfaces.Deposito;
using SCommerce.Domain.Entities.Deposito;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Deposito;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Deposito
{
    public class DepositoTransportadoraAppService : AppServiceBase<DepositoTransportadora>, IDepositoTransportadoraAppService
    {
        public DepositoTransportadoraAppService(IServiceBase<DepositoTransportadora> serviceBase) : base(serviceBase)
        {
        }
    }
}
