using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.Cliente
{
    public class Contato : Base
    {
        public Contato(Guid ID)
            : base(ID)
        {

        }
        
        //public Guid ClienteId { get; set; }
        public Cliente Cliente { get;  set; }
        public ICollection<CadastroBase.Endereco> Enderecos { get;  set; }
        public ICollection<CadastroBase.ContatoTelefone> Telefones { get;  set; }
        public ICollection<CadastroBase.ContatoRedeSocial> RedeSocial { get;  set; }
        public ICollection<CadastroBase.ContatoEmail> Email { get;  set; }
    }
}
