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
    public class EstoqueMovimentoRazaoAppService : AppServiceBase<EstoqueMovimentoRazao>, IEstoqueMovimentoRazaoAppService
    {
        public EstoqueMovimentoRazaoAppService(IServiceBase<EstoqueMovimentoRazao> serviceBase) : base(serviceBase)
        {
        }
    }
}
