using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.Fornecedor
{
    public class FornecedorLoja : Base
    {
        public FornecedorLoja(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdFornecedor { get; set; }
        public Guid IdLoja { get; set; }
        public Fornecedor Fornecedor { get;  set; }
        public CadastroBase.Loja Loja { get;  set; }
    }
}
