
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class CategoriaLojaViewModel : BaseViewModels
    {
        [Display(Name = "Categoria")]
        public CategoriaViewModel Categoria { get; set; }

        [Display(Name = "Loja")]
        public LojaViewModel Loja { get; set; }

        [Display(Name = "Posição")]
        public int Posicao { get; set; }
    }
}
