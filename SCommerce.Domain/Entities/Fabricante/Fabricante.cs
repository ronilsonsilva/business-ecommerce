using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Fabricante
{
    public class Fabricante : Base
    {
        
        public Fabricante(Guid ID)
            : base(ID)
        {

        }
        
        public String Nome { get;  set; }
        public DateTime DataCadastro { get;  set; }
        public DateTime DataAtualizacao { get;  set; }
        public Boolean Ativo { get;  set; }

        public ICollection<FabricanteFornecedor> FabricanteFornecedor { get;  set; }
        public ICollection<FabricanteLoja> FabricanteLoja { get;  set; }
        public ICollection<FabricanteProduto> FabricanteProduto { get;  set; }
    }
}
