using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class ContatoLojaTelefone : Base
    {
        public ContatoLojaTelefone(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdContatoLoja { get; set; }
        public Guid IdContatoTelefone { get; set; }
        public ContatoLoja ContatoLoja { get;  set; }
        public ContatoTelefone ContatoTelefone { get;  set; }
        public ICollection<CMS.CMSWhatsApp> CMSWhatsApps { get; set; }
    }
}
