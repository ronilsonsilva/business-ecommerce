using System;
using System.Collections.Generic;
using System.Linq;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories.Produto;
using SCommerce.Infra.Data.EF;

namespace SCommerce.Infra.Data.Repositories.Produto
{
    public class ProdutoPropriedadeRepository : RepositoryBase<ProdutoPropriedade>, IProdutoPropriedadeRepository
    {
        private readonly ScContext Db = new ScContext();


         public IEnumerable<ProdutoPropriedade> GetPorProduto(Guid idProduto)
         {
            return Db.ProdutoPropriedade.Where(x => x.IdProduto == idProduto);

        }
    }
}
