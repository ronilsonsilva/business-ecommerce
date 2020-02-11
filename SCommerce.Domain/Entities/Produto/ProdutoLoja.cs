using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Enum;

namespace SCommerce.Domain.Entities.Produto
{
    public class ProdutoLoja : Base
    {
        public ProdutoLoja(Guid ID)
            : base(ID)
        {

        }

        public Guid IdProduto { get; set; }
        public Guid IdLoja { get; set; }
        public Produto Produto { get; set; }
        public CadastroBase.Loja Loja { get; set; }
        public Boolean Disponivel { get; set; }
        public Boolean SomenteOnline { get; set; }
        public Boolean ProdutoDigital { get; set; }
        public int QuantidadeMinima { get; set; }
        public Decimal Preco { get; set; }
        public Decimal PrecoAtacado { get; set; }
        public Decimal PrecoUnitario { get; set; }
        public Decimal CustoEnvio { get; set; }
        public String Unidade { get; set; }
        public Boolean Customizavel { get; set; }
        public Boolean UploadArquivos { get; set; }
        public Boolean CampoTexto { get; set; }
        public Boolean Ativo { get; set; }
        public Boolean DisponiveParaOC { get; set; }
        public DateTime DataDisponibilidade { get; set; }
        public Enum.SituacaoProduto SituacaoProduto { get; set; }
        public Boolean ExibirPreco { get; set; }
        public Boolean Indexado { get; set; }
        public Boolean GerenciamentoAvancadoEstoque { get; set; }
        public Enum.VisibilidadeProduto VisibilidadeProduto { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime Atualizado { get; set; }
    }
}
