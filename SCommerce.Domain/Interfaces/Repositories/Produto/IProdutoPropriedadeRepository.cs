using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.Produto
{
    public interface IProdutoPropriedadeRepository : IRepositoryBase<ProdutoPropriedade>
    {
        IEnumerable<ProdutoPropriedade> GetPorProduto(Guid idProduto);
    }
}
