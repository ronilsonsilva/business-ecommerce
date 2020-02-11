using SCommerce.Application.Interfaces.Produto;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Produto
{
    public class ProdutoImagemAppService : AppServiceBase<ProdutoImagem>, IProdutoImagemAppService
    {
        public ProdutoImagemAppService(IServiceBase<ProdutoImagem> serviceBase) : base(serviceBase)
        {
        }
    }
}
