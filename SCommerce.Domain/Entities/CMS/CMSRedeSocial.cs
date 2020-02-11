using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CMS
{
    public class CMSRedeSocial : Base
    {
        public CMSRedeSocial(Guid ID) : base(ID)
        {
        }

        public Guid IdLoja { get; set; }
        public CadastroBase.Loja Loja { get; set; }
        public String Nome { get; set; }
        public String IconeType { get; set; }
        public Byte[] Icone { get; set; }
        public String Url { get; set; }
    }
}
