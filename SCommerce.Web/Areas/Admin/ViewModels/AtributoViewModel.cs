using SCommerce.Web.ViewModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class AtributoViewModel : BaseViewModels
    {
        [Display(Name = "Produto")]
        public ProdutoViewModel Produto { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Descrição")]
        public String Descricao { get; set; }

        [Display(Name = "Customizável")]
        public Boolean Custmizavel { get; set; }
    }
}
