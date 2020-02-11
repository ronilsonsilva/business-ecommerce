using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.Produto;

namespace SCommerce.Domain.Entities.Carrinho
{
    public class CarrinhoProduto : Base
    {
        public CarrinhoProduto(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdCarrinho { get; set; }
        public Carrinho Carrinho { get;  set; }
        public Guid IdProduto { get; set; }
        public Produto.Produto Produto { get;  set; }
        public int Quantidade { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }
    }
}
