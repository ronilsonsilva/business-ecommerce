using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Produto
{
    public class Tag : Base
    {
        public Tag(Guid ID)
            : base(ID)
        {

        }
        
        public String Nome { get;  set; }
        public String Valor { get;  set; }

        public ICollection<ProdutoTag> ProdutoTags { get; set; }
    }
}
