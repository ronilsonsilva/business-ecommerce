using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class ContatoRedeSocial : Base
    {
        public ContatoRedeSocial(Guid ID)
            : base(ID)
        {

        }
        

        public String RedeSocial { get;  set; }
        public String URL { get;  set; }
        public String IdentificadorUsuario { get;  set; }

        public ICollection<ContatoLojaRedeSocial> ContatoLojaRedeSocials { get; set; }
    }
}
