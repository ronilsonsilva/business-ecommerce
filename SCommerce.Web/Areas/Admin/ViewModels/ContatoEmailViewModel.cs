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
    public class ContatoEmailViewModel : BaseViewModels
    {
        [Display(Name = "E-mail")]
        public String Email { get; set; }

        [Display(Name = "Nome do Contato")]
        public String NomeContato { get; set; }

        public static ContatoEmailViewModel Mapear(ContatoEmail contatoEmail)
        {
            var saida = new ContatoEmailViewModel();
            if (contatoEmail != null)
            {
                saida = new ContatoEmailViewModel()
                {
                    Email = contatoEmail.Email,
                    ID = contatoEmail.ID,
                    NomeContato = contatoEmail.NomeContato
                };
            }
            
            return saida;
        }
        public static ICollection<ContatoEmailViewModel> Mapear(ICollection<ContatoEmail> contatoEmails)
        {
            Collection<ContatoEmailViewModel> saida = new Collection<ContatoEmailViewModel>();
            if (contatoEmails != null)
            {
                foreach (var item in contatoEmails)
                {
                    saida.Add(ContatoEmailViewModel.Mapear(item));
                }
            }
            return saida;
        }
    }
}
