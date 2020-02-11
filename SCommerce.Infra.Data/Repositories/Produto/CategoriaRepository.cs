using System;
using System.Collections.Generic;
using System.Linq;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories.Produto;
using SCommerce.Infra.Data.EF;

namespace SCommerce.Infra.Data.Repositories.Produto
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
        private readonly ScContext Db = new ScContext();

        public int CategoriaComProdutos()
        {
            try
            {
                return Db.Produto.Select(x => x.IdCategoriaPadrao).Distinct().Count();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IEnumerable<Categoria> GetCategoriasRoot()
        {
            try
            {
                return Db.Categoria.Where(x => x.Root == true && x.Ativo == true);
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }

        public IEnumerable<Categoria> GetFilhosDaCategoriasRoot(Guid idCategoria)
        {
            try
            {
                return Db.Categoria.Where(x => x.IDCategoriaPai == idCategoria && x.Ativo == true);
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }

        public IEnumerable<Categoria> GetIrmaosDaCategoriasRoot(Guid idCategoria)
        {
            try
            {
                var categoria = Db.Categoria.Find(idCategoria);
                if (categoria != null)
                {
                    return Db.Categoria.Where(x => x.IDCategoriaPai == categoria.IDCategoriaPai && x.Ativo == true);
                }
                return new List<Categoria>();
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }
    }
}
