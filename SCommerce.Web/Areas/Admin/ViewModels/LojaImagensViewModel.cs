using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class LojaImagensViewModel : BaseViewModels
    {
        [Display(Name = "Loja")]
        public LojaViewModel Loja { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Arquivo")]
        [DataType(DataType.Upload)]
        public Byte[] Arquivo { get; set; }

        [Display(Name = "Formato do Arquivo")]
        public String Formato { get; set; }

        [Display(Name = "Logomarca")]
        public Boolean Logomarca { get; set; }

        [Display(Name = "Ícone")]
        public Boolean Icone { get; set; }
    }
}
