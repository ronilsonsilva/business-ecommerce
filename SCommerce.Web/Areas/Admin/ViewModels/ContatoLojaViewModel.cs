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
    public class ContatoLojaViewModel : BaseViewModels
    {
        [Display(Name = "Telefone")]
        public ICollection<ContatoLojaTelefoneViewModel> ContatoLojaTelefones { get; set; }

        [Display(Name = "Telefone")]
        public ContatoLojaTelefoneViewModel ContatoLojaTelefone { get; set; }

        [Display(Name = "Loja")]
        public LojaViewModel Loja { get; set; }

        [Display(Name = "E-mail")]
        public ICollection<ContatoLojaEmailViewModel> ContatoLojaEmails { get; set; }

        [Display(Name = "E-mail")]
        public ContatoLojaEmailViewModel ContatoLojaEmail { get; set; }

        [Display(Name = "Nome do Contato")]
        public String NomeContato { get; set; }

        [Display(Name = "Endereços")]
        public ICollection<ContatoLojaEnderecoViewModel> ContatoLojaEnderecos { get; set; }

        [Display(Name = "Endereços")]
        public ContatoLojaEnderecoViewModel ContatoLojaEndereco { get; set; }

        [Display(Name = "Rede Social")]
        public ICollection<ContatoLojaRedeSocialViewModel> ContatoLojaRedeSocials { get; set; }

        [Display(Name = "Rede Social")]
        public ContatoLojaRedeSocialViewModel ContatoLojaRedeSocial { get; set; }


        public static ContatoLojaViewModel Mapear(ContatoLoja contatoLoja)
        {
            var saida = new ContatoLojaViewModel();
            if (contatoLoja != null)
            {
                saida = new ContatoLojaViewModel()
                {
                    ContatoLojaEmails = ContatoLojaEmailViewModel.Mapear(contatoLoja?.ContatoLojaEmails),
                    ContatoLojaEnderecos = ContatoLojaEnderecoViewModel.Mapear(contatoLoja?.ContatoLojaEnderecos),
                    ContatoLojaTelefones = ContatoLojaTelefoneViewModel.Mapear(contatoLoja?.ContatoLojaTelefones),
                    ContatoLojaRedeSocials = ContatoLojaRedeSocialViewModel.Mapear(contatoLoja?.ContatoLojaRedeSocials),
                    ID = contatoLoja.ID,
                    //Loja = LojaViewModel.Mapear(contatoLoja?.Loja),
                    NomeContato = contatoLoja.NomeContato
                };
            }
            return saida;
        }

        public static ICollection<ContatoLojaViewModel> Mapear(ICollection<ContatoLoja> contatoLojas)
        {
            var saida = new Collection<ContatoLojaViewModel>();
            if (contatoLojas != null)
            {
                foreach (var item in contatoLojas)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }
    }
}
