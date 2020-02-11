
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class CampoCustomizavelViewModel : BaseViewModels
    {
        [Display(Name = "Produto")]
        public ProdutoViewModel Produto { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Obrigatório")]
        public Boolean Obrigatorio { get; set; }
    }
}
