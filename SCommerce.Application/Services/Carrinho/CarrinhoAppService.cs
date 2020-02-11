using SCommerce.Application.Interfaces.Carrinho;
using SCommerce.Domain.Entities.Carrinho;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Carrinho;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Carrinho
{
    public class CarrinhoAppService : AppServiceBase<Domain.Entities.Carrinho.Carrinho>, ICarrinhoAppService
    {
        public CarrinhoAppService(Domain.Interfaces.Services.IServiceBase<Domain.Entities.Carrinho.Carrinho> serviceBase) : base(serviceBase)
        {
        }
    }
}
