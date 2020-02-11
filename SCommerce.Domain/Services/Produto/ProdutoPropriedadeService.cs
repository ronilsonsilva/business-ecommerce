using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Produto
{
    public class ProdutoPropriedadeService : ServiceBase<ProdutoPropriedade>, IProdutoPropriedadeService
    {
        public ProdutoPropriedadeService(IRepositoryBase<ProdutoPropriedade> repository) : base(repository)
        {
        }
    }
}
