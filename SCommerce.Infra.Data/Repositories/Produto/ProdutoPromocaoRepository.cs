using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.Repositories.Produto
{
    public class ProdutoPromocaoRepository : RepositoryBase<ProdutoPromocao>, IProdutoPromocaoRepository
    {
    }
}
