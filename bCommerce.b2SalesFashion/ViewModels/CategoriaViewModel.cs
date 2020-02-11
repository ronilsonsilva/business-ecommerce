
using System;
using System.ComponentModel.DataAnnotations;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class CategoriaViewModel : BaseViewModels
    {
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

        
    }
}
