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
    public class ContatoLojaEnderecoViewModel : BaseViewModels
    {
        [Display(Name = "Loja do Contato")]
        public ContatoLojaViewModel ContatoLoja { get; set; }

        [Display(Name = "Endereço")]
        public EnderecoViewModel Endereco { get; set; }

        [Display(Name = "Loja do Contato")]
        public Guid IdContatoLoja { get; set; }

        [Display(Name = "Endereço")]
        public Guid IdEndereco { get; set; }

        public static ContatoLojaEnderecoViewModel Mapear(ContatoLojaEndereco contatoLojaEndereco)
        {
            var saida = new ContatoLojaEnderecoViewModel();
            if (contatoLojaEndereco != null)
            {
                saida = new ContatoLojaEnderecoViewModel()
                {
                    //ContatoLoja = ContatoLojaViewModel.Mapear(contatoLojaEndereco?.ContatoLoja),
                    Endereco = EnderecoViewModel.Mapear(contatoLojaEndereco?.Endereco),
                    ID = contatoLojaEndereco.ID,
                    IdContatoLoja = contatoLojaEndereco.IdContatoLoja,
                    IdEndereco = contatoLojaEndereco.IdEndereco
                };
            }
            
            return saida;
        }

        public static ICollection<ContatoLojaEnderecoViewModel> Mapear(ICollection<ContatoLojaEndereco> contatoLojaEndereco)
        {
            var saida = new Collection<ContatoLojaEnderecoViewModel>();
            if (contatoLojaEndereco != null)
            {
                foreach (var item in contatoLojaEndereco)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }
    }
}
