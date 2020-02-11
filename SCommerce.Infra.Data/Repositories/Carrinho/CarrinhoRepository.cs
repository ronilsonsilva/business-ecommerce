using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SCommerce.Domain.Entities.Carrinho;
using SCommerce.Domain.Interfaces.Repositories.Carrinho;

namespace SCommerce.Infra.Data.Repositories.Carrinho
{
    public class CarrinhoRepository : RepositoryBase<Domain.Entities.Carrinho.Carrinho>, ICarrinhoRepository
    {
        public Domain.Entities.Carrinho.Carrinho GetCarrinho(Guid idCliente)
        {
            try
            {
                var carrinho = Db.Carrinho.Where(x => x.GerarOC == false && x.IdCliente == idCliente).Include(x => x.CarrinhoProdutos).FirstOrDefault();
                return carrinho;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public Domain.Entities.Carrinho.Carrinho GetCarrinhoDoCliente(Guid idCarrinho)
        {
            try
            {
                var carrinho = Db.Carrinho.Where(x => x.GerarOC == false && x.ID == idCarrinho).Include(x => x.CarrinhoProdutos).FirstOrDefault();
                return carrinho;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
