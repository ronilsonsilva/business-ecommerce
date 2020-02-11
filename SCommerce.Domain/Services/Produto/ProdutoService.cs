using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Produto
{
    public class ProdutoService : ServiceBase<Entities.Produto.Produto>, IProdutoService
    {
        public ProdutoService(IRepositoryBase<Entities.Produto.Produto> repository) : base(repository)
        {
        }
    }
}
