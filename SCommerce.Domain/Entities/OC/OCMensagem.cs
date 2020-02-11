using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.OC
{
    public class OCMensagem : Base
    {
        public OCMensagem(Guid ID)
            : base(ID)
        {

        }

        
        public DateTime Data { get;  set; }
        public Boolean Lida { get;  set; }
        public Boolean Privada { get;  set; }
        public String Mensagem { get;  set; }

        public Guid IdOC { get; set; }
        public OC OC { get;  set; }
        public Guid idEmitente { get; set; }
        public int Posicao { get; set; }
        public ICollection<CadastroBase.Anexo> Anexos { get;  set; }
    }
}
