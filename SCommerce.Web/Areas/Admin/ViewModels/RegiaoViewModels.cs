using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class RegiaoViewModels : BaseViewModels
    {
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Ativo")]
        public Boolean Ativa { get; set; }
    }
}
