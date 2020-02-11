using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CMS
{
    public class CMSWhatsApp : Base
    {
        public CMSWhatsApp(Guid ID) : base(ID)
        {
        }
        public String Observacao { get; set; }
        public Boolean Exibir { get; set; }
        public Boolean Principal { get; set; }

        public Guid IDContatoLojaTelefone { get; set; }
        public CadastroBase.ContatoLojaTelefone ContatoLojaTelefone { get; set; }
    }
}
