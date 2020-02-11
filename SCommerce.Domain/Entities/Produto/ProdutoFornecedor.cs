using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.Financeiro;
using SCommerce.Domain.Entities.Fornecedor;

namespace SCommerce.Domain.Entities.Produto
{
    public class ProdutoFornecedor : Base
    {
        public ProdutoFornecedor(Guid ID)
            : base(ID)
        {

        }

        public Guid IdProduto { get; set; }
        public Guid IdFornecedor { get; set; }
        public Produto Produto { get;  set; }
        public Fornecedor.Fornecedor Fornecedor { get;  set; }
        public String ReferenciaFornecedor { get;  set; }
        public Decimal PrecoFornecedor { get;  set; }
    }
}
