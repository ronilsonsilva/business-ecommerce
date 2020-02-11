using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Financeiro
{
    public class Moeda : Base
    {
        public Moeda(Guid ID)
            : base(ID)
        {

        }
        
        public String Nome { get;  set; }
        public String CodigoIso { get;  set; }
        public String sign { get;  set; }
        public int CodigoIsoNumerico { get;  set; }
        public Boolean EmBRanco { get;  set; }
        public Boolean Formato { get;  set; }
        public Boolean Decimal { get;  set; }
        public Boolean Ativo { get;  set; }
        public Boolean Deletado { get;  set; }
        public Decimal TaxaConversao { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }
    }
}
