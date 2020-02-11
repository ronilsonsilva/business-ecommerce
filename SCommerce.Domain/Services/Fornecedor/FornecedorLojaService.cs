using SCommerce.Domain.Entities.Fornecedor;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Fornecedor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Fornecedor
{
    public class FornecedorLojaService : ServiceBase<FornecedorLoja>, IFornecedorLojaService
    {
        public FornecedorLojaService(IRepositoryBase<FornecedorLoja> repository) : base(repository)
        {
        }
    }
}
