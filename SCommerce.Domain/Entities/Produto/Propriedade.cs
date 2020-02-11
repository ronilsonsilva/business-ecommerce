using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Produto
{
    public class Propriedade : Base
    {
        public Propriedade(Guid ID)
            : base(ID)
        {

        }
        
        public Guid? IdPai { get;  set; }
        public String Nome { get;  set; }
        public String Descricao { get;  set; }
        public Boolean Customizavel { get;  set; }
        public Boolean ValorUnico { get;  set; }

        public ICollection<PropriedadeValor> propriedadeValors { get; set; }
        public ICollection<ProdutoPropriedade> ProdutoPropriedades { get; set; }
    }
}
