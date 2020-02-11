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

        public static ICollection<Pais> Mapear(ICollection<PaisViewModel> paises)
        {
            var saida = new Collection<Pais>();
            if (paises != null)
            {
                foreach (var item in paises)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }

        public static Pais Mapear(PaisViewModel pais)
        {
            var saida = new Pais(Guid.Empty);
            if (pais != null)
            {
                saida = new Pais(Guid.Empty)
                {
                    Codigo = pais.Codigo,
                    ID = pais.ID != null && pais.ID != Guid.Empty ? pais.ID : Guid.NewGuid(),
                    Nome = pais.Nome
                };
            }
            return saida;
        }

        public static ICollection<PaisViewModel> Mapear(ICollection<Pais> paises)
        {
            var saida = new Collection<PaisViewModel>();
            if (paises != null)
            {
                foreach (var item in paises)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }
    }
}
