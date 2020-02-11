using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Transportadora;

namespace SCommerce.Domain.Entities.Produto
{
    public class ProdutoTransportadora : Base
    {
        public ProdutoTransportadora(Guid ID)
            : base(ID)
        {

        }

        public Guid IdProduto { get; set; }
        public Guid IdTransportadora { get; set; }
        public Transportadora.Transportadora Transportadora { get;  set; }
        public Produto Produto { get;  set; }
    }
}
