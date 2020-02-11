using SCommerce.Domain.Entities.Fabricante;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Fabricante;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Fabricante
{
    public class FabricanteFornecedorService : ServiceBase<FabricanteFornecedor>, IFabricanteFornecedorService
    {
        public FabricanteFornecedorService(IRepositoryBase<FabricanteFornecedor> repository) : base(repository)
        {
        }
    }
}
