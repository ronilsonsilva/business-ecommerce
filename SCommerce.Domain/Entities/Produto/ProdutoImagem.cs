using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Produto
{
    public class ProdutoImagem : Base
    {
        public ProdutoImagem(Guid ID)
            : base(ID)
        {

        }

        public Guid IdProduto { get; set; }
        public Produto Produto { get;  set; }
        public Byte[] Arquivo { get;  set; }
        public String Formato { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizada { get;  set; }
    }
}
