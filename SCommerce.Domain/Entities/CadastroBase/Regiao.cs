using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class Regiao : Base
    {
        public Regiao(Guid ID)
            : base(ID)
        {

        }
        
        public String Nome { get;  set; }
        public Boolean Ativa { get;  set; }
    }
}
