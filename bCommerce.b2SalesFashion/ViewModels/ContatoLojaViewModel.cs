
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class ContatoLojaViewModel : BaseViewModels
    {
        [Display(Name = "Telefone")]
        public ICollection<ContatoLojaTelefoneViewModel> ContatoLojaTelefones { get; set; }

        [Display(Name = "Loja")]
        public LojaViewModel Loja { get; set; }

        [Display(Name = "E-mail")]
        public ICollection<ContatoLojaEmailViewModel> ContatoLojaEmails { get; set; }

        [Display(Name = "Nome do Contato")]
        public String NomeContato { get; set; }

        [Display(Name = "Endereços")]
        public ICollection<ContatoLojaEnderecoViewModel> ContatoLojaEnderecos { get; set; }

        [Display(Name = "Rede Social")]
        public ICollection<ContatoLojaRedeSocialViewModel> ContatoLojaRedeSocials { get; set; }
    }
}
