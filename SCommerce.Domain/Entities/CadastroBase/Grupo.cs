using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class Grupo : Base
    {
        public Grupo(Guid ID)
            : base(ID)
        {

        }
        

        public String Nome { get;  set; }
        public String Descricao { get;  set; }
        public ICollection<ProdutoGrupo> ProdutoGrupos { get; set; }
    }
}
