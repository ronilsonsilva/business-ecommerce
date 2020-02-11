
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class PaisViewModel : BaseViewModels
    {
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Código")]
        public String Codigo { get; set; }

        [Display(Name = "Estados")]
        public ICollection<ProvinciaViewModel> Provincias { get; set; }

        [Display(Name = "Cidades")]
        public ICollection<CidadeViewModel> Cidades { get; set; }

        public static PaisViewModel Mapear(Pais pais)
        {
            try
            {
                var saida = new PaisViewModel();
                if (pais != null)
                {
                    saida = new PaisViewModel()
                    {
                        Codigo = pais.Codigo,
                        ID = pais.ID,
                        Nome = pais.Nome
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<PaisViewModel> Mapear(ICollection<Pais> paises)
        {
            try
            {
                var saida = new Collection<PaisViewModel>();
                if (paises != null)
                {
                    foreach (var item in paises)
                    {
                        var pais = Mapear(item);
                        saida.Add(pais);
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
