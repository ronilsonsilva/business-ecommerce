using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Web.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class ContatoLojaTelefoneViewModel : BaseViewModels
    {
        [Display(Name = "Loja do Contato")]
        public ContatoLojaViewModel ContatoLoja { get; set; }

        [Display(Name = "Telefone")]
        public ContatoTelefoneViewModel ContatoTelefone { get; set; }

        [Display(Name = "Loja do Contato")]
        public Guid IdContatoLoja { get; set; }

        [Display(Name = "Telefone")]
        public Guid IdContatoTelefone { get; set; }

        public static ContatoLojaTelefoneViewModel Mapear(ContatoLojaTelefone contatoLojaTelefone)
        {
            var saida = new ContatoLojaTelefoneViewModel();
            if (contatoLojaTelefone != null)
            {
                saida = new ContatoLojaTelefoneViewModel()
                {
                    //ContatoLoja = ContatoLojaViewModel.Mapear(contatoLojaTelefone?.ContatoLoja),
                    ContatoTelefone = ContatoTelefoneViewModel.Mapear(contatoLojaTelefone?.ContatoTelefone),
                    ID = contatoLojaTelefone.ID
                };
            }
            
            return saida;
        }


        public static ICollection<ContatoLojaTelefoneViewModel> Mapear(ICollection<ContatoLojaTelefone> contatoLojaTelefones)
        {
            var saida = new Collection<ContatoLojaTelefoneViewModel>();
            if (contatoLojaTelefones != null)
            {
                foreach (var item in contatoLojaTelefones)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }
    }
}
