
using System.ComponentModel.DataAnnotations;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class ContatoLojaTelefoneViewModel : BaseViewModels
    {
        [Display(Name = "Loja do Contato")]
        public ContatoLojaViewModel ContatoLoja { get; set; }

        [Display(Name = "Telefone")]
        public ContatoTelefoneViewModel ContatoTelefone { get; set; }
    }
}
