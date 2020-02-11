using SCommerce.Domain.Entities.Carrinho;
using SCommerce.Domain.Interfaces.Repositories.Carrinho;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SCommerce.Infra.Data.Repositories.Carrinho
{
    public class CarrinhoProdutoRepository : RepositoryBase<CarrinhoProduto>, ICarrinhoProdutoRepository
    {
        public ICollection<CarrinhoProduto> GetCarrinhoProduto(Guid idCarrinho)
        {
            try
            {
                return Db.CarrinhoProdutos.Where(x => x.IdCarrinho == idCarrinho).ToList();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
