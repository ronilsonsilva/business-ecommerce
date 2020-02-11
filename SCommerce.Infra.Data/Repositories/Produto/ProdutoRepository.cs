using Microsoft.EntityFrameworkCore;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories.Produto;
using SCommerce.Infra.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCommerce.Infra.Data.Repositories.Produto
{
    public class ProdutoRepository : RepositoryBase<Domain.Entities.Produto.Produto>, IProdutoRepository
    {

        public Domain.Entities.Produto.Produto GetProduto(Guid idProduto)
        {
            try
            {
                var produto = Db.Produto.Where(x => x.ID == idProduto).FirstOrDefault();
                if (produto != null)
                {
                    produto.imagens = Db.ProdutoImagem.Where(x => x.IdProduto == produto.ID).ToList();
                }
                return produto;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IEnumerable<Domain.Entities.Produto.Produto> GetProdutosDaCategoria(Guid idCategoria)
        {
            try
            {
                return Db.Produto.Where(x => x.Ativo && x.IdCategoriaPadrao == idCategoria)
                    .Include(x => x.imagens);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void SalvarProduto(Domain.Entities.Produto.Produto produto)
        {
            try
            {
                Db.Attach(produto).State = EntityState.Added;
                Db.SaveChanges();
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }

        public void UpdateProduto(Domain.Entities.Produto.Produto produto)
        {
            try
            {
                
                Db.Attach<Domain.Entities.Produto.Produto>(produto).State = EntityState.Modified;
                Db.SaveChanges();
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }
    }
}
