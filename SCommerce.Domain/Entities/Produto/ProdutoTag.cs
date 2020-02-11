using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Produto
{
    public class ProdutoTag : Base
    {
        public ProdutoTag(Guid ID)
            : base(ID)
        {

        }
        public Guid IdProduto { get; set; }
        public Guid IdTag { get; set; }
        public Produto Produto { get;  set; }
        public Tag Tag { get;  set; }
    }
}
