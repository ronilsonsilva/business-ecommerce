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
    public class ContatoLojaRedeSocialViewModel : BaseViewModels
    {
        [Display(Name = "Perfil na Rede Social")]
        public ContatoRedeSocialViewModel contatoRedeSocial { get; set; }

        [Display(Name = "Loja do Contato")]
        public ContatoLojaViewModel ContatoLoja { get; set; }

        public Guid IdContatoRedeSocial { get; set; }
        public Guid IdContatoLoja { get; set; }

        public static ContatoLojaRedeSocialViewModel Mapear(ContatoLojaRedeSocial contatoLojaRedeSocial)
        {
            var saida = new ContatoLojaRedeSocialViewModel();
            if (contatoLojaRedeSocial != null)
            {
                saida = new ContatoLojaRedeSocialViewModel()
                {
                    //ContatoLoja = ContatoLojaViewModel.Mapear(contatoLojaRedeSocial?.ContatoLoja),
                    contatoRedeSocial = ContatoRedeSocialViewModel.Mapear(contatoLojaRedeSocial?.ContatoRedeSocial),
                    ID = contatoLojaRedeSocial.ID,
                    IdContatoLoja = contatoLojaRedeSocial.IdContatoLoja,
                    IdContatoRedeSocial = contatoLojaRedeSocial.IdContatoRedeSocial
                };
            }
            
            return saida;
        }

        public static ICollection<ContatoLojaRedeSocialViewModel> Mapear(ICollection<ContatoLojaRedeSocial> contatoLojaRedeSocials)
        {
            var saida = new Collection<ContatoLojaRedeSocialViewModel>();
            if (contatoLojaRedeSocials != null)
            {
                foreach (var item in contatoLojaRedeSocials)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }
    }
}
