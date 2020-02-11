using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.Produto;

namespace SCommerce.Domain.Entities.Fabricante
{
    public class FabricanteProduto : Base
    {
        public FabricanteProduto(Guid ID)
            : base(ID)
        {

        }

        public Guid IdProduto { get; set; }
        public Guid IdFabricante { get; set; }
        public Fabricante Fabricante { get;  set; }
        public Produto.Produto Produto { get;  set; }
    }
}
