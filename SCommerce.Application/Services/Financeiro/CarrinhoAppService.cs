﻿using SCommerce.Application.Interfaces.Financeiro;
using SCommerce.Domain.Entities.Financeiro;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Financeiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Financeiro
{
    public class CarrinhoAppService : AppServiceBase<Domain.Entities.Carrinho.Carrinho>, ICarrinhoAppService
    {
        public CarrinhoAppService(IServiceBase<Domain.Entities.Carrinho.Carrinho> serviceBase) : base(serviceBase)
        {
        }
    }
}
