using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Produto
{
    public class ProdutoPromocao : Base
    {
        public ProdutoPromocao(Guid ID) : base(ID)
        {
        }

        public Guid IdProduto { get; set; }
        public Produto Produto { get; set; }
        public Decimal PercentualDesconto { get; set; }
        public Decimal ValorDesconto { get; set; }
        public Decimal ValorAnterior { get; set; }
        public Decimal ValorComDesconto { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime Atualizado { get; set; }
        public DateTime DataInicioPromocao { get; set; }
        public DateTime DataFimPromocao { get; set; }

    }
}
