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
    public class DepositoLojaAppService : AppServiceBase<DepositoLoja>, IDepositoLojaAppService
    {
        public DepositoLojaAppService(IServiceBase<DepositoLoja> serviceBase) : base(serviceBase)
        {
        }
    }
}
