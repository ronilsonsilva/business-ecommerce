using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Produto
{
    public class PropriedadeValor : Base
    {
        public PropriedadeValor(Guid ID)
            : base(ID)
        {

        }

        public Guid IdPropriedade { get; set; }
        public Propriedade Propriedade { get;  set; }
        public String Nome { get;  set; }
        public String Valor { get;  set; }
        public Enum.Dados TipoDado { get; set; }
        
        
    }
}
