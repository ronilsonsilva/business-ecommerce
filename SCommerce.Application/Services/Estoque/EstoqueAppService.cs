using SCommerce.Application.Interfaces.Estoque;
using SCommerce.Domain.Entities.Deposito;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Estoque;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Estoque
{
    public class EstoqueAppService : AppServiceBase<Domain.Entities.Deposito.Deposito>, IEstoqueAppService
    {
        public EstoqueAppService(IServiceBase<Domain.Entities.Deposito.Deposito> serviceBase) : base(serviceBase)
        {
        }
    }
}
