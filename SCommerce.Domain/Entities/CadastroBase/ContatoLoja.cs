using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class ContatoLoja : Base
    {
        public ContatoLoja(Guid ID)
            : base(ID)
        {

        }
        
        public String NomeContato { get;  set; }
        public Loja Loja { get;  set; }
        public Guid IdLoja { get; set; }
        public ICollection<ContatoLojaTelefone> ContatoLojaTelefones { get;  set; }
        public ICollection<ContatoLojaEmail> ContatoLojaEmails { get;  set; }
        public ICollection<ContatoLojaEndereco> ContatoLojaEnderecos { get;  set; }
        public ICollection<ContatoLojaRedeSocial> ContatoLojaRedeSocials { get;  set; }
    }
}
