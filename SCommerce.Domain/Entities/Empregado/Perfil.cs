using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Empregado
{
    public class Perfil : Base
    {
        public Perfil(Guid ID)
            :base(ID)
        {

        }
        
        public String Nome { get;  set; }
        public ICollection<Acesso> Acessos { get; set; }
        public ICollection<Empregado> Empregados { get; set; }
    }
}
