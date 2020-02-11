
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class DepartamentoViewModel : BaseViewModels
    {
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Pai")]
        public Guid IdPai { get; set; }

        [Display(Name = "Lojas")]
        public ICollection<LojaDepartamentoViewModel> LojaDepartamentos { get; set; }
    }
}
