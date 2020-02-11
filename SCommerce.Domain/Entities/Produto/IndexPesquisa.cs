using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Produto
{
    public class IndexPesquisa : Base
    {
        public IndexPesquisa(Guid ID)
            : base(ID)
        {

        }
        
        public String Palvara { get;  set; }
        public int Peso { get;  set; }
    }
}
