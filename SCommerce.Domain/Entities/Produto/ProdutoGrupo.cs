using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.Produto
{
    public class ProdutoGrupo : Base
    {
        public ProdutoGrupo(Guid ID)
            : base(ID)
        {

        }

        public Guid IdProduto { get; set; }
        public Guid IdGrupo { get; set; }
        public Produto Produto { get;  set; }
        public CadastroBase.Grupo Grupo { get;  set; }
    }
}
