
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class ContatoLojaEmailViewModel : BaseViewModels
    {
        [Display(Name = "Loja do Contato")]
        public ContatoLojaViewModel ContatoLoja { get; set; }

        [Display(Name = "E-mail")]
        public ContatoEmailViewModel ContatoEmail { get; set; }
    }
}
