using SCommerce.Application.Interfaces.Fornecedor;
using SCommerce.Domain.Entities.Fornecedor;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Fornecedor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Fornecedor
{
    public class FornecedorLojaAppService : AppServiceBase<FornecedorLoja>, IFornecedorLojaAppService
    {
        public FornecedorLojaAppService(IServiceBase<FornecedorLoja> serviceBase) : base(serviceBase)
        {
        }
    }
}
