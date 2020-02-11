using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Produto
{
    public class ProdutoPropriedade : Base
    {
        public ProdutoPropriedade(Guid ID)
            : base(ID)
        {

        }

        public Guid IdPropriedade { get; set; }
        public Guid IdProduto { get; set; }
        public Propriedade Propriedade { get;  set; }
        public Produto Produto { get;  set; }
    }
}
