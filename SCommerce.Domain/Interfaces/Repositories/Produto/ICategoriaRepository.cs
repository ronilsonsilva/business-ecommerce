using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.Produto
{
    public interface ICategoriaRepository : IRepositoryBase<Categoria>
    {
        IEnumerable<Categoria> GetCategoriasRoot();
        IEnumerable<Categoria> GetFilhosDaCategoriasRoot(Guid idCategoria);
        IEnumerable<Categoria> GetIrmaosDaCategoriasRoot(Guid idCategoria);
        int CategoriaComProdutos();
    }
}
