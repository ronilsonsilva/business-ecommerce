
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class PropriedadeValorViewModel : BaseViewModels
    {
        [Display(Name = "Propriedade")]
        public PropriedadeViewModel Propriedade { get; set; }

        [Display(Name = "Valor")]
        public String Valor { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Entrada de Dados")]
        public SCommerce.Domain.Enum.Dados TipoDado { get; set; }

    }
}
