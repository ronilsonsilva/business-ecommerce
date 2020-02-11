using System;
using System.Collections.Generic;
using System.Linq;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories.Produto;
using SCommerce.Infra.Data.EF;

namespace SCommerce.Infra.Data.Repositories.Produto
{
    public class ProdutoImagemRepository : RepositoryBase<ProdutoImagem>, IProdutoImagemRepository
    {
        private readonly ScContext Db = new ScContext();


        public IEnumerable<ProdutoImagem> GetPorProduto(Guid idProduto)
        {
            return Db.ProdutoImagem.Where(x => x.IdProduto == idProduto);
        }
    }
}
