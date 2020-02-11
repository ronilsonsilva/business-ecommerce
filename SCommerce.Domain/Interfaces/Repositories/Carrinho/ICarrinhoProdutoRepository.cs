using SCommerce.Domain.Entities.Carrinho;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.Carrinho
{
    public interface ICarrinhoProdutoRepository : IRepositoryBase<CarrinhoProduto>
    {
        ICollection<CarrinhoProduto> GetCarrinhoProduto(Guid idCarrinho);
    }
}
