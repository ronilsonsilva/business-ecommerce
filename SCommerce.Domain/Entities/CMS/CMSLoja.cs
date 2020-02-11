using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.CMS
{
    public class CMSLoja : Base
    {
        public CMSLoja(Guid ID)
            : base(ID)
        {

        }
        
        
        public Guid IdLoja { get; set; }
        public CadastroBase.Loja Loja { get;  set; }
        public String IconeType { get; set; }
        public Byte[] Icone { get; set; }
        public String LogoType { get; set; }
        public Byte[] Logo { get; set; }
        public String LogoType2 { get; set; }
        public Byte[] Logo2 { get; set; }

    }
}
