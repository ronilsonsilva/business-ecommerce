using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class LojaImagens : Base
    {
        public LojaImagens(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdLoja { get; set; }
        public Loja Loja { get;  set; }
        public String Nome { get;  set; }
        public Byte[] Arquivo { get;  set; }
        public String Formato { get;  set; }
        public Boolean Logomarca { get;  set; }
        public Boolean Icone { get;  set; }
    }
}
