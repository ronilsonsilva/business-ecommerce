using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class Provincia : Base
    {
        public Provincia(Guid ID)
            : base(ID)
        {

        }
        
        public String Nome { get;  set; }
        public String CodigoISO { get;  set; }
        public Decimal ImpostoPermitido { get;  set; }
        public Boolean Ativo { get;  set; }

        public Guid IdPais { get; set; }
        public Pais Pais { get;  set; }

        public ICollection<Cidade> Cidades { get;  set; }
    }
}
