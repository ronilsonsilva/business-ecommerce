using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.OC;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Enum;

namespace SCommerce.Domain.Entities.Cliente
{
    public class ClienteProcesso : Base
    {
        public ClienteProcesso(Guid ID)
            : base(ID)
        {

        }
        
        public Enum.StatusProcesso Status { get;  set; }
        public DateTime DataCadastro { get;  set; }
        public DateTime DataAtualizacao { get;  set; }

        public Guid IdOC { get; set; }
        public OC.OC OC { get;  set; }

        public ICollection<ClienteMensagem> ClienteMensagens { get; set; }
    }
}
