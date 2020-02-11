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
    public class CidadeViewModel : BaseViewModels
    {
        [Display(Name = "Estado")]
        public ProvinciaViewModel Provincia { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        public static CidadeViewModel Mapear(Cidade cidade)
        {
            var saida = new CidadeViewModel();
            if (cidade != null)
            {
                saida = new CidadeViewModel()
                {
                    ID = cidade.ID,
                    Nome = cidade.Nome,
                    Provincia = ProvinciaViewModel.Mapear(cidade?.Provincia)
                };
            }
            
            return saida;
        }

        public static ICollection<CidadeViewModel> Mapear(ICollection<Cidade> cidades)
        {
            var saida = new Collection<CidadeViewModel>();
            if (cidades != null)
            {
                foreach (var item in cidades)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }

        public static Cidade Mapear(CidadeViewModel cidade)
        {
            var saida = new Cidade(Guid.Empty);
            if (cidade != null)
            {
                saida = new Cidade(Guid.Empty)
                {
                    ID = cidade.ID != null && cidade.ID != Guid.Empty ? cidade.ID : Guid.NewGuid(),
                    Nome = cidade.Nome,
                    Provincia = ProvinciaViewModel.Mapear(cidade?.Provincia)
                };
            }

            return saida;
        }

        public static ICollection<Cidade> Mapear(ICollection<CidadeViewModel> cidades)
        {
            var saida = new Collection<Cidade>();
            if (cidades != null)
            {
                foreach (var item in cidades)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }
    }
}
