using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Financeiro
{
    public class MetodoPagamento : Base
    {
        public MetodoPagamento(Guid ID)
            :base(ID)
        {

        }
        

        public String Nome { get;  set; }
        public String Observacao { get; set; }
        public ICollection<OC.OC> OCs { get; set; }
    }
}
