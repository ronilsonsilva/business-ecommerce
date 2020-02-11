
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class ContatoRedeSocialViewModel : BaseViewModels
    {
        [Display(Name = "Rede Social")]
        public String RedeSocial { get; set; }

        [Display(Name = "URL")]
        public String URL { get; set; }

        [Display(Name = "Nome do Perfil")]
        public String IdentificadorUsuario { get; set; }
    }
}
