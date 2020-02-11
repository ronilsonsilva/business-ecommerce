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
    public class ProvinciaViewModel : BaseViewModels
    {
        [Display(Name = "País")]
        public PaisViewModel Pais { get; set; }

        [Display(Name = "Região")]
        public RegiaoViewModels Regiao { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Código ISO")]
        public String CodigoISO { get; set; }

        [Display(Name = "Imposto Permitido")]
        public Decimal ImpostoPermitido { get; set; }

        [Display(Name = "Ativo")]
        public Boolean Ativo { get; set; }

        [Display(Name = "Cidades")]
        public ICollection<CidadeViewModel> Cidades { get; set; }

        public static ProvinciaViewModel Mapear(Provincia provincia)
        {
            var saida = new ProvinciaViewModel();
            if (provincia != null)
            {
                saida = new ProvinciaViewModel()
                {
                    Ativo = provincia.Ativo,
                    CodigoISO = provincia.CodigoISO,
                    ID = provincia.ID,
                    ImpostoPermitido = provincia.ImpostoPermitido,
                    Nome = provincia.Nome,
                    Pais = PaisViewModel.Mapear(provincia?.Pais)
                };
            }
            return saida;
        }

        public static ICollection<ProvinciaViewModel> Mapear(ICollection<Provincia> provincias)
        {
            var saida = new Collection<ProvinciaViewModel>();
            if (provincias != null)
            {
                foreach (var item in provincias)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }

        public static Provincia Mapear(ProvinciaViewModel provincia)
        {
            var saida = new Provincia(Guid.Empty);
            if (provincia != null)
            {
                saida = new Provincia(Guid.Empty)
                {
                    Ativo = provincia.Ativo,
                    CodigoISO = provincia.CodigoISO,
                    ID = provincia.ID != null && provincia.ID != Guid.Empty ? provincia.ID : Guid.NewGuid(),
                    ImpostoPermitido = provincia.ImpostoPermitido,
                    Nome = provincia.Nome,
                    Pais = PaisViewModel.Mapear(provincia?.Pais)
                };
            }
            return saida;
        }

        public static ICollection<Provincia> Mapear(ICollection<ProvinciaViewModel> provincias)
        {
            var saida = new Collection<Provincia>();
            if (provincias != null)
            {
                foreach (var item in provincias)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }
    }
}
