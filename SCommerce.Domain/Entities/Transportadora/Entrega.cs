using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.Transportadora
{
    public class Entrega : Base
    {
        public Entrega(Guid ID)
            : base(ID)
        {

        }
        
        public Decimal Preco { get;  set; }
        public Decimal Peso { get; set; }
        public String Descricao { get; set; }

        
        public Guid IdTransportadora { get; set; }
        public Transportadora Transportadora { get;  set; }
        public Guid IdOC { get; set; }
        public OC.OC OC { get; set; }
    }
}
