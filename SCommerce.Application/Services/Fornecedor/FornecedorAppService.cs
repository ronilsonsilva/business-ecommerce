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
    public class FornecedorAppService : AppServiceBase<Domain.Entities.Fornecedor.Fornecedor>, IFornecedorAppService
    {
        public FornecedorAppService(IServiceBase<Domain.Entities.Fornecedor.Fornecedor> serviceBase) : base(serviceBase)
        {
        }
    }
}
