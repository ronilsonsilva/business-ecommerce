using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Produto
{
    public class Atributo : Base
    {
        public Atributo(Guid ID)
            : base(ID)
        {

        }
        
        //public Guid ProdutoId { get; set; }
        public Produto Produto { get;  set; }
        public String Nome { get;  set; }
        public String Descricao { get;  set; }
        public Boolean Custmizavel { get;  set; }
    }
}
