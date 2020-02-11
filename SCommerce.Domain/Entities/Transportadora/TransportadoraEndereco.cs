using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.Transportadora
{
    public class TransportadoraEndereco : Base
    {
        public TransportadoraEndereco(Guid ID)
            : base(ID)
        {

        }

        public Guid IdTranportadora { get; set; }
        public Guid IdEndereco { get; set; }
        public Transportadora Transportadora { get; set; }
        public CadastroBase.Endereco Endereco { get; set; }
    }
}
