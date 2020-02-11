using SCommerce.b2SalesFashion.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bCommerce.b2SalesFashion.ViewModels
{
    public class LojaHomeViewModel
    {
        [Display(Name = "Nome")]
        public string NomeCategoria { get; set; }

        [Display(Name = "ID")]
        public Guid? IdCategoria { get; set; }

        public List<CategoriasLojaViewModel> CategoriasHomeViewModels { get; set; }
        public List<ProdutoViewModel> Produtos { get; set; }
    }

    public class CategoriasLojaViewModel
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
}
