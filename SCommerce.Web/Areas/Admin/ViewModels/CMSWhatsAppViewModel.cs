using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class CMSWhatsAppViewModel : BaseViewModels
    {
        [Display(Name = "Observação")]
        public String Observacao { get; set; }

        [Display(Name = "Exibir no site")]
        public Boolean Exibir { get; set; }

        [Display(Name = "Contato Principal")]
        public Boolean Principal { get; set; }

        [Display(Name = "Telefone")]
        public Guid IDContatoLojaTelefone { get; set; }
        public ContatoLojaTelefoneViewModel ContatoLojaTelefone { get; set; }
    }

}
