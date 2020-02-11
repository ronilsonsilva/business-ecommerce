using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class ContatoEmail : Base
    {
        public ContatoEmail(Guid ID)
            : base(ID)
        {

        }
        
        public String Email { get;  set; }
        public String NomeContato { get;  set; }

        public ICollection<ContatoLojaEmail> ContatoLojaEmails { get; set; }
    }
}
