using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class Pais : Base
    {
        public Pais(Guid ID)
            : base(ID)
        {

        }
        
        public String Nome { get;  set; }
        public String Codigo { get;  set; }
        public ICollection<Provincia> Provincias { get;  set; }
    }
}
