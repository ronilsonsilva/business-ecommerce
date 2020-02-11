using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class ContatoLojaEmailViewModel : BaseViewModels
    {
        [Display(Name = "Loja do Contato")]
        public ContatoLojaViewModel ContatoLoja { get; set; }

        [Display(Name = "E-mail")]
        public ContatoEmailViewModel ContatoEmail { get; set; }

        public Guid IdContatoLoja { get; set; }
        public Guid IdContatoEmail { get; set; }

        public static ContatoLojaEmailViewModel Mapear(ContatoLojaEmail contatoLojaEmail)
        {
            var saida = new ContatoLojaEmailViewModel();
            if (contatoLojaEmail != null)
            {
                saida = new ContatoLojaEmailViewModel()
                {
                    ContatoEmail = ContatoEmailViewModel.Mapear(contatoLojaEmail?.ContatoEmail),
                    //ContatoLoja = ContatoLojaViewModel.Mapear(contatoLojaEmail?.ContatoLoja),
                    ID = contatoLojaEmail.ID,
                    IdContatoEmail = contatoLojaEmail.IdContatoEmail,
                    IdContatoLoja = contatoLojaEmail.IdContatoLoja
                };
            }
            
            return saida;
        }

        public static ICollection<ContatoLojaEmailViewModel> Mapear(ICollection<ContatoLojaEmail> contatoLojaEmails)
        {
            var saida = new Collection<ContatoLojaEmailViewModel>();
            if (contatoLojaEmails != null)
            {
                foreach (var item in contatoLojaEmails)
                {
                    saida.Add(ContatoLojaEmailViewModel.Mapear(item));
                }
            }
            
            return saida;
        }
    }
}
