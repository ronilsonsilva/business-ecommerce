using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class CategoriaProdutoViewModel : BaseViewModels
    {
        [Display(Name = "Produto")]
        public ProdutoViewModel Produto { get; set; }

        [Display(Name = "Categoria")]
        public CategoriaViewModel Categoria { get; set; }

        [Display(Name = "Posição")]
        public int Posicao { get; set; }
    }
}
