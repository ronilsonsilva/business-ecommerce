using SCommerce.Web.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class LojaDepartamentoViewModel : BaseViewModels
    {
        [Display(Name = "Loja")]
        public LojaViewModel Loja { get; set; }

        [Display(Name = "Departamento")]
        public DepartamentoViewModel Departamento { get; set; }
    }
}
