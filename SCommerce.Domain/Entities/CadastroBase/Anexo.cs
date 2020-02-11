using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class Anexo : Base
    {
        public Anexo(Guid ID) 
            : base (ID)
        {

        }
        public String Nome { get; set; }
        public String Tipo { get; set; }
        public Byte[] Arquivo { get; set; }
        public Guid IdOCMensagem { get; set; }
        public OC.OCMensagem OCMensagems { get; set; }
    }
}
