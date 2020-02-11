using SCommerce.Application.Interfaces.Carrinho;
using SCommerce.Domain.Entities.Carrinho;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Carrinho;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Carrinho
{
    public class CarrinhoProdutoAppService : AppServiceBase<CarrinhoProduto>, ICarrinhoProdutoAppService
    {
        public CarrinhoProdutoAppService(IServiceBase<CarrinhoProduto> serviceBase) : base(serviceBase)
        {
        }
    }
}
