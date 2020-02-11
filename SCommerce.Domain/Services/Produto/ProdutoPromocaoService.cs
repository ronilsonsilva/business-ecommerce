using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Produto
{
    public class ProdutoPromocaoService : ServiceBase<ProdutoPromocao>, IProdutoPromocaoService
    {
        public ProdutoPromocaoService(IRepositoryBase<ProdutoPromocao> repository) : base(repository)
        {
        }
    }
}
