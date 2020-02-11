using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.Fornecedor;

namespace SCommerce.Domain.Entities.Fabricante
{
    public class FabricanteFornecedor : Base
    {
        public FabricanteFornecedor(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdFornecedor { get; set; }
        public Guid IdFabricante { get; set; }
        public Fornecedor.Fornecedor Fornecedor { get;  set; }
        public Fabricante Fabricante { get;  set; }
    }
}
