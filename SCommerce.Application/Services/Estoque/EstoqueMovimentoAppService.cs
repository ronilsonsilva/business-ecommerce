using SCommerce.Application.Interfaces.Estoque;
using SCommerce.Domain.Entities.Estoque;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Estoque;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Estoque
{
    public class EstoqueMovimentoAppService : AppServiceBase<EstoqueMovimento>, IEstoqueMovimentoAppService
    {
        public EstoqueMovimentoAppService(IServiceBase<EstoqueMovimento> serviceBase) : base(serviceBase)
        {
        }
    }
}
