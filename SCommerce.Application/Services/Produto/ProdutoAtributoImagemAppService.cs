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
    public class ProdutoAtributoImagemAppService : AppServiceBase<ProdutoAtributoImagem>, IProdutoAtributoImagemAppService
    {
        public ProdutoAtributoImagemAppService(IServiceBase<ProdutoAtributoImagem> serviceBase) : base(serviceBase)
        {
        }
    }
}
