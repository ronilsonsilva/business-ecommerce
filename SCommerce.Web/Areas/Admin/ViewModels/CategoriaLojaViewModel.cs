using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class CategoriaLojaViewModel : BaseViewModels
    {
        [Display(Name = "Categoria")]
        public Guid IdCategoria { get; set; }
        public CategoriaViewModel Categoria { get; set; }

        [Display(Name = "Loja")]
        public Guid IdLoja { get; set; }

        public LojaViewModel Loja { get; set; }

        [Display(Name = "Posição")]
        public int Posicao { get; set; }

        
    }
}
