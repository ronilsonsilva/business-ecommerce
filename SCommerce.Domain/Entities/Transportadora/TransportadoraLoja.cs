using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.Transportadora
{
    public class TransportadoraLoja : Base
    {
        public TransportadoraLoja(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdLoja { get; set; }
        public Guid IdTransportadora { get; set; }
        public CadastroBase.Loja Loja { get;  set; }
        public Transportadora Transportadora { get;  set; }
    }
}
