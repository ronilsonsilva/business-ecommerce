using SCommerce.b2SalesFashion.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bCommerce.b2SalesFashion.ViewModels
{
    public class HomeIndexViewModel
    {
        public String btnSubmit { get; set; }

        public List<CategoriasHomeViewModel> CategoriasHomeViewModels { get; set; }
        public List<PromocaoHomeIndexViewModel> PromocaoHomeIndexViewModels { get; set; }
        public List<ProdutosMaisVendidos> ProdutosMaisVendidos { get; set; }
    }

    public class CategoriasHomeViewModel
    {
        [Display(Name = "ID")]
        public Guid ID { get; set; }

        [Display(Name = "Categoria Pai")]
        public Guid IdCategoriaPai { get; set; }

        [Display(Name = "Categoria Pai")]
        public CategoriaViewModel CategoriaPai { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Loja Padrão da Categoria")]
        public LojaViewModel LojaPadrao { get; set; }

        [Display(Name = "Nível de Profunbdidade")]
        public Boolean LevelDepth { get; set; }

        [Display(Name = "Ativo?")]
        public Boolean Ativo { get; set; }

        [Display(Name = "É root?")]
        public Boolean Root { get; set; }

        [Display(Name = "N Esquerda")]
        public int NLeft { get; set; }

        [Display(Name = "N Direita")]
        public int NRight { get; set; }

        [Display(Name = "Posição da Categoria")]
        public int Posicao { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        public DateTime Cadastro { get; set; }

        [Display(Name = "Última atualização")]
        [DataType(DataType.DateTime)]
        public DateTime Atualizado { get; set; }

        public List<ProdutoViewModel> Produtos { get; set; }
    }

    public class PromocaoHomeIndexViewModel
    {

     
        public Guid ID { get; set; }


        [Display(Name = "Categoria")]
        public CategoriaViewModel CategoriaPadrao { get; set; }

        [Display(Name = "Categoria")]
        public Guid IdCategoriaPadrao { get; set; }

        

        [Required]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public Decimal Preco { get; set; }

        [Display(Name = "Preço de Atacado")]
        [DataType(DataType.Currency)]
        public Decimal PrecoAtacado { get; set; }

       

        [Required]
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Required]
        [Display(Name = "Nome para exibir")]
        public String NomeExibicao { get; set; }

        [Required]
        [Display(Name = "Breve descrição")]
        public String DescricaoCurta { get; set; }

        

        [Display(Name = "Imagens")]
        public List<ProdutoImagemViewModel> imagensProduto { get; set; }
        
    }

    public class ProdutosMaisVendidos
    {
        public Guid ID { get; set; }


        [Display(Name = "Categoria")]
        public CategoriaViewModel CategoriaPadrao { get; set; }

        [Display(Name = "Categoria")]
        public Guid IdCategoriaPadrao { get; set; }



        [Required]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public Decimal Preco { get; set; }

        [Display(Name = "Preço de Atacado")]
        [DataType(DataType.Currency)]
        public Decimal PrecoAtacado { get; set; }



        [Required]
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Required]
        [Display(Name = "Nome para exibir")]
        public String NomeExibicao { get; set; }

        [Required]
        [Display(Name = "Breve descrição")]
        public String DescricaoCurta { get; set; }



        [Display(Name = "Imagens")]
        public List<ProdutoImagemViewModel> imagensProduto { get; set; }
    }
}
