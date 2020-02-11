using SCommerce.Web.ViewModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class ProdutoAtributoViewModel : BaseViewModels
    {
        [Display(Name = "Produto")]
        public ProdutoViewModel Produto { get; set; }

        [Display(Name = "Referência")]
        public String Referencia { get; set; }

        [Display(Name = "Referência do Fornecedor")]
        public String ReferenciaFornecedor { get; set; }

        [Display(Name = "Referência do Fabricante")]
        public String ReferenciaFabricante { get; set; }

        [Display(Name = "Localização")]
        public String Localizaocao { get; set; }

        [Display(Name = "Código Padrão EAN13")]
        public String EAN13 { get; set; }

        [Display(Name = "Código Padrão UPC")]
        public String UPC { get; set; }

        [Display(Name = "Preço de Atacado")]
        public Decimal PrecoAtacado { get; set; }

        [Display(Name = "Preço")]
        public Decimal Preco { get; set; }

        [Display(Name = "Ecotax")]
        public Decimal Ecotax { get; set; }

        [Display(Name = "Peso")]
        public Decimal Peso { get; set; }

        [Display(Name = "Diferença Preço Unitário")]
        public Decimal ImpactoPrecoUnitario { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Quantidade Mínima")]
        public int QuantidadeMinima { get; set; }

        [Display(Name = "Data de Disponibilidade")]
        public DateTime Diponibilidade { get; set; }
    }
}
