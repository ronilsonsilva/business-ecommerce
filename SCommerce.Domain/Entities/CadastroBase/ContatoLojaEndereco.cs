using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class ContatoLojaEndereco : Base
    {
        public ContatoLojaEndereco(Guid ID)
            : base(ID)
        {

        }

        public Guid IdContatoLoja { get; set; }
        public Guid IdEndereco { get; set; }
        public ContatoLoja ContatoLoja { get;  set; }
        public Endereco Endereco { get;  set; }

        public ICollection<CMS.CMSEnderecoLoja> CMSEnderecoLojas { get; set; }
    }
}
