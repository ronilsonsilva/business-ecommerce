using SCommerce.Domain.Entities.Carrinho;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Carrinho;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Carrinho
{
    public class CarrinhoProdutoService : ServiceBase<CarrinhoProduto>, ICarrinhoProdutoService
    {
        public CarrinhoProdutoService(IRepositoryBase<CarrinhoProduto> repository) : base(repository)
        {
        }
    }
}
