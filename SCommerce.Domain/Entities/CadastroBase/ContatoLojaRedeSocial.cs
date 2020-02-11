using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class ContatoLojaRedeSocial : Base
    {
        public ContatoLojaRedeSocial(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdContatoRedeSocial { get; set; }
        public Guid IdContatoLoja { get; set; }
        public ContatoRedeSocial ContatoRedeSocial { get;  set; }
        public ContatoLoja ContatoLoja { get;  set; }
    }
}
