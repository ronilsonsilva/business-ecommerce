using SCommerce.Domain.Entities.Fornecedor;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Fornecedor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Fornecedor
{
    public class FornecedorService : ServiceBase<Entities.Fornecedor.Fornecedor>, IFornecedorService
    {
        public FornecedorService(IRepositoryBase<Entities.Fornecedor.Fornecedor> repository) : base(repository)
        {
        }
    }
}
