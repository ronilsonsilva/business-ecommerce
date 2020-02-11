using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class Cidade : Base
    {
        public Cidade(Guid ID)
            : base(ID)
        {

        }

        
        public Guid IdProvincia { get; set; }
        public Provincia Provincia { get;  set; }
        public String Nome { get;  set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}
