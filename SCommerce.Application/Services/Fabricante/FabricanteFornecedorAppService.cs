using SCommerce.Application.Interfaces.Fabricante;
using SCommerce.Domain.Entities.Fabricante;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Fabricante;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Fabricante
{
    public class FabricanteFornecedorAppService : AppServiceBase<FabricanteFornecedor>, IFabricanteFornecedorAppService
    {
        public FabricanteFornecedorAppService(IServiceBase<FabricanteFornecedor> serviceBase) : base(serviceBase)
        {
        }
    }
}
