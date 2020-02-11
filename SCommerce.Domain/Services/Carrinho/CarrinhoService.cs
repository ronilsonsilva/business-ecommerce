using SCommerce.Domain.Entities.Carrinho;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Carrinho;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Carrinho
{
    public class CarrinhoService : ServiceBase<Entities.Carrinho.Carrinho>, ICarrinhoService
    {
        public CarrinhoService(IRepositoryBase<Entities.Carrinho.Carrinho> repository) : base(repository)
        {
        }
    }
}
