using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.Carrinho
{
    public interface ICarrinhoRepository : IRepositoryBase<Entities.Carrinho.Carrinho>
    {
        Entities.Carrinho.Carrinho GetCarrinho(Guid idCliente);
        Entities.Carrinho.Carrinho GetCarrinhoDoCliente(Guid idCarrinho);
    }
}
