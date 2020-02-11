using Microsoft.AspNetCore.Http;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class ProdutoViewModel : BaseViewModels
    {
        [Display(Name = "Fabricante")]
        public FabricanteViewModels Fabricante { get; set; }

        [Display(Name = "Fabricante")]
        public Guid FabricanteId { get; set; }


        [Display(Name = "Categoria")]
        public CategoriaViewModel CategoriaPadrao { get; set; }

        [Display(Name = "Categoria")]
        public Guid IdCategoriaPadrao { get; set; }

        [Display(Name = "Loja Padrão")]
        public LojaViewModel LojaPadrao { get; set; }

        [Display(Name = "Loja Padrão")]
        public Guid LojaId { get; set; }

        [Display(Name = "Diponível")]
        public Boolean Disponivel { get; set; }

        [Display(Name = "Somente Online")]
        public Boolean SomenteOnline { get; set; }

        [Display(Name = "Código Padrão EAN13")]
        public String EAN13 { get; set; }

        [Display(Name = "Código Padrão UPC")]
        public String UPC { get; set; }

        [Display(Name = "Ecotax")]
        public Decimal Ecotax { get; set; }

        [Display(Name = "Quantidade Mínima")]
        public int QuantidadeMinima { get; set; }

        [Display(Name = "Quantidade Disponível")]
        public int Quantidade { get; set; }

        [Required]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public Decimal Preco { get; set; }

        [Display(Name = "Preço de Atacado")]
        [DataType(DataType.Currency)]
        public Decimal PrecoAtacado { get; set; }

        [Display(Name = "Unidade")]
        public String Unidade { get; set; }

        [Required]
        [Display(Name = "Referência")]
        [DataType(DataType.Text)]
        public String Referencia { get; set; }

        [Display(Name = "Referência do Fornecedor")]
        [DataType(DataType.Text)]
        public String ReferenciaFornecedor { get; set; }

        [Display(Name = "Referência do Fabricante")]
        [DataType(DataType.Text)]
        public String ReferenciaFabricante { get; set; }

        [Display(Name = "Impacto de Preço Unitário")]
        public Decimal ImpactoPrecoUnitario { get; set; }

        [Required]
        [Display(Name = "Custo de Envio")]
        public Decimal CustoEnvio { get; set; }

        [Display(Name = "Largura")]
        public Decimal Largura { get; set; }

        [Display(Name = "Altura")]
        public Decimal Altura { get; set; }

        [Display(Name = "Profundidade")]
        public Decimal Profundidade { get; set; }

        [Display(Name = "Peso")]
        public Decimal Peso { get; set; }

        [Required]
        [Display(Name = "Fora de Estoque")]
        public Boolean ForaDeEstoque { get; set; }

        [Display(Name = "Ativo")]
        public Boolean Ativo { get; set; }

        [Display(Name = "Customizável")]
        public Boolean Customizavel { get; set; }

        [Display(Name = "Upload de Arquivos")]
        public Boolean UploadArquivos { get; set; }

        [Display(Name = "Campo de Texto")]
        public Boolean CampoTexto { get; set; }

        [Display(Name = "Disponível para Pedido")]
        public Boolean DisponivelParaOC { get; set; }

        [Required]
        [Display(Name = "Exibir Preço")]
        public Boolean ExibirPreco { get; set; }

        [Display(Name = "Indexado")]
        public Boolean Indexado { get; set; }

        [Display(Name = "Tem Anexo Oculto")]
        public Boolean TemAnexoOculto { get; set; }

        [Display(Name = "Produto Digital")]
        public Boolean ProdutoDigital { get; set; }

        [Display(Name = "Gerenciamento Avançado Estoque")]
        public Boolean GerenciamentoAvancadoEstoque { get; set; }

        [Display(Name = "Desconto Por Quantidade")]
        public Boolean DescontoPorQuantidade { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Required]
        [Display(Name = "Nome para exibir")]
        public String NomeExibicao { get; set; }

        [Required]
        [Display(Name = "Breve descrição")]
        public String DescricaoCurta { get; set; }

        [Display(Name = "Propriedades")]
        public Guid PropriedadeView { get; set; }


        [Display(Name = "Situação do Produto")]
        public Domain.Enum.SituacaoProduto Condicao { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        public DateTime Cadastro { get; set; }

        [Display(Name = "Última Atualização")]
        [DataType(DataType.DateTime)]
        public DateTime Atualizado { get; set; }

        [Display(Name = "Imagens")]
        public ICollection<ProdutoImagemViewModel> imagensProduto { get; set; }

        public ICollection<IFormFile> arquivosImagens { get; set; }

        [Display(Name = "Propriedades")]
        public List<ProdutoPropriedadeViewModel> ProdutoPropriedadesViewmodel { get; set; }
        //public ICollection<Carrinho.CarrinhoProduto> CarrinhoProdutos { get; set; }


        public static ProdutoViewModel Mapear(Produto produto)
        {
            try
            {
                var saida = new ProdutoViewModel();
                if (produto != null)
                {
                    saida = new ProdutoViewModel()
                    {
                        Altura = produto.Altura,
                        Ativo = produto.Ativo,
                        Atualizado = produto.Atualizado,
                        Cadastro = produto.Cadastro,
                        CampoTexto = produto.CampoTexto,
                        Condicao = produto.Condicao,
                        CustoEnvio = produto.CustoEnvio,
                        Customizavel = produto.Customizavel,
                        DescontoPorQuantidade = produto.DescontoPorQuantidade,
                        DescricaoCurta = produto.DescricaoCurta,
                        Disponivel = produto.Disponivel,
                        DisponivelParaOC = produto.DisponivelParaOC,
                        EAN13 = produto.EAN13,
                        Ecotax = produto.Ecotax,
                        ExibirPreco = produto.ExibirPreco,
                        ForaDeEstoque = produto.ForaDeEstoque,
                        GerenciamentoAvancadoEstoque = produto.GerenciamentoAvancadoEstoque,
                        ID = produto.ID,
                        IdCategoriaPadrao = produto.IdCategoriaPadrao,
                        ImpactoPrecoUnitario = produto.ImpactoPrecoUnitario,
                        Indexado = produto.Indexado,
                        Largura = produto.Largura,
                        LojaId = produto.IdLojaPadrao,
                        Nome = produto.Nome,
                        NomeExibicao = produto.NomeExibicao,
                        Peso = produto.Peso,
                        Preco = produto.Preco,
                        PrecoAtacado = produto.PrecoAtacado,
                        ProdutoDigital = produto.ProdutoDigital,
                        Profundidade = produto.Profundidade,
                        Quantidade = produto.Quantidade,
                        QuantidadeMinima = produto.QuantidadeMinima,
                        Referencia = produto.Referencia,
                        ReferenciaFabricante = produto.ReferenciaFabricante,
                        ReferenciaFornecedor = produto.ReferenciaFornecedor,
                        SomenteOnline = produto.SomenteOnline,
                        TemAnexoOculto = produto.TemAnexoOculto,
                        Unidade = produto.Unidade,
                        UPC = produto.UPC,
                        UploadArquivos = produto.UploadArquivos,
                        imagensProduto = ProdutoImagemViewModel.Mapear(produto.imagens)
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<ProdutoViewModel> Mapear(ICollection<Produto> produtos)
        {
            try
            {
                var saida = new Collection<ProdutoViewModel>();
                if (produtos != null)
                {
                    foreach (var item in produtos)
                    {
                        var produto = Mapear(item);
                        saida.Add(produto);
                    }
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
