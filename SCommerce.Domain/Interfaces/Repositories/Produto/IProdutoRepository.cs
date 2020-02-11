using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.Produto
{
    public interface IProdutoRepository : IRepositoryBase<Entities.Produto.Produto>
    {
        void SalvarProduto(Entities.Produto.Produto produto);
        void UpdateProduto(Domain.Entities.Produto.Produto produto);
        IEnumerable<Domain.Entities.Produto.Produto> GetProdutosDaCategoria(Guid idCategoria);
        Entities.Produto.Produto GetProduto(Guid idProduto);
    }
}
