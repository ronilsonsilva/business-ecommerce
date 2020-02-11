
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class CidadeViewModel : BaseViewModels
    {
        [Display(Name = "Estado")]
        public Guid idProvincia { get; set; }

        [Display(Name = "Estado")]
        public ProvinciaViewModel Provincia { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        public static CidadeViewModel Mapear(Cidade cidade)
        {
            try
            {
                var saida = new CidadeViewModel();
                if (cidade != null)
                {
                    saida = new CidadeViewModel()
                    {
                        ID = cidade.ID,
                        idProvincia = cidade.IdProvincia,
                        Nome = cidade.Nome,
                        Provincia = ProvinciaViewModel.Mapear(cidade.Provincia)
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<CidadeViewModel> Mapear(ICollection<Cidade> cidades)
        {
            try
            {
                var saida = new Collection<CidadeViewModel>();
                if (cidades != null)
                {
                    foreach (var item in cidades)
                    {
                        var cidade = Mapear(item);
                        saida.Add(cidade);
                    }
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
