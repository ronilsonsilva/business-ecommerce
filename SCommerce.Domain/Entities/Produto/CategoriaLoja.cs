using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.Produto
{
    public class CategoriaLoja : Base
    {
        public CategoriaLoja(Guid ID)
            : base(ID)
        {

        }

        public int Posicao { get;  set; }

        public Guid IdLoja { get; set; }
        public Guid IdCategoria { get; set; }
        public Categoria Categoria { get;  set; }
        public CadastroBase.Loja Loja { get;  set; }
    }
}
