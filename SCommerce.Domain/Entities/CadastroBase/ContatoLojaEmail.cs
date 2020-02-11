using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class ContatoLojaEmail : Base
    {
        public ContatoLojaEmail(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdContatoLoja { get; set; }
        public Guid IdContatoEmail { get; set; }
        public ContatoLoja ContatoLoja { get;  set; }
        public ContatoEmail ContatoEmail { get;  set; }
    }
}
