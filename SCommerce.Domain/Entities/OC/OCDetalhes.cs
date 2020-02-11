using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Produto;

namespace SCommerce.Domain.Entities.OC
{
    public class OCDetalhes : Base
    {
        public OCDetalhes(Guid ID)
            : base(ID)
        {

        }
        
        public int Quantidade { get;  set; }
        public String Observacao { get; set; }

        public Guid IdOC { get; set; }
        public OC OC { get;  set; }
        public Guid IdProduto { get; set; }
        public Produto.Produto Produto { get; set; }
    }
}
