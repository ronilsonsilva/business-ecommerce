using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Empregado;

namespace SCommerce.Domain.Entities.Cliente
{
    public class ClienteMensagem : Base
    {
        public ClienteMensagem(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdClienteProcesso { get; set; }
        public ClienteProcesso ClienteProcesso { get;  set; }
        public String Mensagem { get;  set; }
        public DateTime Data { get;  set; }
        public DateTime Editada { get;  set; }
        public Boolean Privada { get;  set; }
        public Boolean Lida { get;  set; }
        public Byte[] Audio { get; set; }
    }
}
