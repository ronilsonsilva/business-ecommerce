
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class ContatoLojaRedeSocialViewModel : BaseViewModels
    {
        [Display(Name = "Perfil na Rede Social")]
        public ContatoRedeSocialViewModel contatoRedeSocial { get; set; }

        [Display(Name = "Loja do Contato")]
        public ContatoLojaViewModel ContatoLoja { get; set; }
    }
}
