
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class ContatoEmailViewModel : BaseViewModels
    {
        [Display(Name = "E-mail")]
        public String Email { get; set; }

        [Display(Name = "Nome do Contato")]
        public String NomeContato { get; set; }
    }
}
