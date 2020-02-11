using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Enum;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class ContatoTelefone : Base
    {
        public ContatoTelefone(Guid ID)
            : base(ID)
        {

        }
        
        public String Descricao { get;  set; }
        public int CodigoLocal { get;  set; }
        public int CodigoNacional { get;  set; }
        public String Operadora { get;  set; }
        public String Numero { get;  set; }
        public Enum.ContatoTelefone TipoContato { get;  set; }
        public Guid? IdCliente { get; set; }
        public Cliente.Cliente Cliente { get; set; }
        public ICollection<ContatoLojaTelefone> ContatoLojaTelefones { get; set; }
    }
}
