using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Produto
{
    public class CategoriaProduto : Base
    {
        public CategoriaProduto(Guid ID)
            : base(ID)
        {

        }

        public Guid IdProduto { get; set; }
        public Guid IdCategoria { get; set; }
        public Produto Produto { get;  set; }
        public Categoria Categoria { get;  set; }
        public int Posicao { get;  set; }
    }
}
