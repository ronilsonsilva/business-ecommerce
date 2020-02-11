using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CMS
{
    public class CMSEnderecoLoja : Base
    {
        public CMSEnderecoLoja(Guid ID) : base(ID)
        {
        }

        public String Observacao { get; set; }
        public String ImagemType { get; set; }
        public Byte[] Imagem { get; set; }
        public Decimal Latitute { get; set; }
        public Decimal Longitude { get; set; }
        public Boolean ExibirMapa { get; set; }

        public Guid IdContatoLojaEndereco { get; set; }
        public ContatoLojaEndereco ContatoLojaEndereco { get; set; }
    }
}
