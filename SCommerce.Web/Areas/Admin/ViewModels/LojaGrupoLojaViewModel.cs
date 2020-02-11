using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class LojaGrupoLojaViewModel : BaseViewModels
    {
        [Display(Name = "Loja")]
        public LojaViewModel Loja { get; set; }

        [Display(Name = "Grupo da Loja")]
        public LojaGrupoViewModel LojaGrupo { get; set; }
    }
}
