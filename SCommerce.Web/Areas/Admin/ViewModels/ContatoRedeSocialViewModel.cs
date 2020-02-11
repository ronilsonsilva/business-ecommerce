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
    public class ContatoRedeSocialViewModel : BaseViewModels
    {
        [Display(Name = "Rede Social")]
        public String RedeSocial { get; set; }

        [Display(Name = "URL")]
        public String URL { get; set; }

        [Display(Name = "Nome do Perfil")]
        public String IdentificadorUsuario { get; set; }

        public static ContatoRedeSocialViewModel Mapear(ContatoRedeSocial contatoRedeSocial)
        {
            var saida = new ContatoRedeSocialViewModel();
            if (contatoRedeSocial != null)
            {
                saida = new ContatoRedeSocialViewModel()
                {
                    ID = contatoRedeSocial.ID,
                    IdentificadorUsuario = contatoRedeSocial.IdentificadorUsuario,
                    RedeSocial = contatoRedeSocial.RedeSocial,
                    URL = contatoRedeSocial.URL
                };
            }
            
            return saida;
        }

        public static ICollection<ContatoRedeSocialViewModel> Mapear(ICollection<ContatoRedeSocial> contatoRedeSocials)
        {
            var saida = new Collection<ContatoRedeSocialViewModel>();
            if (contatoRedeSocials != null)
            {
                foreach (var item in contatoRedeSocials)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }
    }
}
