using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Fabricante;
using SCommerce.Domain.Entities.Fornecedor;
using SCommerce.Domain.Enum;

namespace SCommerce.Domain.Entities.Produto
{
    public class Produto : Base
    {
        public Produto(Guid ID)
            : base(ID)
        {

        }
        
        public Boolean Disponivel { get;  set; }
        public Boolean SomenteOnline { get;  set; }
        public String EAN13 { get;  set; }
        public String UPC { get;  set; }
        public Decimal Ecotax { get;  set; }
        public int QuantidadeMinima { get;  set; }
        public int Quantidade { get;  set; }
        public Decimal Preco { get;  set; }
        public Decimal PrecoAtacado { get;  set; }
        public String Unidade { get;  set; }
        public String Referencia { get;  set; }
        public String ReferenciaFornecedor { get;  set; }
        public String ReferenciaFabricante { get;  set; }
        public Decimal ImpactoPrecoUnitario { get;  set; }
        public Decimal CustoEnvio { get;  set; }
        public Decimal Largura { get;  set; }
        public Decimal Altura { get;  set; }
        public Decimal Profundidade { get;  set; }
        public Decimal Peso { get;  set; }
        public Boolean ForaDeEstoque { get;  set; }
        public Boolean Ativo { get;  set; }
        public Boolean Customizavel { get;  set; }
        public Boolean UploadArquivos { get;  set; }
        public Boolean CampoTexto { get;  set; }
        public Boolean DisponivelParaOC { get;  set; }
        public Boolean ExibirPreco { get;  set; }
        public Boolean Indexado { get;  set; }
        public Boolean TemAnexoOculto { get;  set; }
        public Boolean ProdutoDigital { get;  set; }
        public Boolean GerenciamentoAvancadoEstoque { get;  set; }
        public Boolean DescontoPorQuantidade { get;  set; }
        public Enum.SituacaoProduto Condicao { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }
        public String Nome { get; set; }
        public String NomeExibicao { get; set; }
        public String DescricaoCurta { get; set; }

        public Guid IdCategoriaPadrao { get; set; }
        public Categoria CategoriaPadrao { get; set; }
        public Guid IdLojaPadrao { get; set; }
        public CadastroBase.Loja LojaPadrao { get; set; }

        public ICollection<ProdutoImagem> imagens { get;  set; }
        public ICollection<Carrinho.CarrinhoProduto> CarrinhoProdutos { get; set; }
        public ICollection<ProdutoPropriedade> ProdutoPropriedades { get; set; }
        public ICollection<ProdutoTag> ProdutoTags { get; set; }
        public ICollection<FabricanteProduto> FabricanteProdutos { get; set; }
        public ICollection<ProdutoCategoria> ProdutoCategorias { get; set; }
        public ICollection<ProdutoTransportadora> ProdutoTransportadoras { get; set; }
        public ICollection<ProdutoFornecedor> ProdutoFornecedors { get; set; }
        public ICollection<ProdutoGrupo> ProdutoGrupos { get; set; }
        public ICollection<ProdutoLoja> ProdutoLojas { get; set; }
        public ICollection<OC.OCDetalhes> OCDetalhes { get; set; }
        public ICollection<ProdutoPromocao> ProdutoPromocaos { get; set; }
    }
}
