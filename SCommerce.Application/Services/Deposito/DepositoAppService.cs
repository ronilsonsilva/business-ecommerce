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
    public class DepositoAppService : AppServiceBase<Domain.Entities.Deposito.Deposito>, IDepositoAppService
    {
        public DepositoAppService(IServiceBase<Domain.Entities.Deposito.Deposito> serviceBase) : base(serviceBase)
        {
        }
    }
}
