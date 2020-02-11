
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
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
            try
            {
                var saida = new ProvinciaViewModel();
                if (provincia != null)
                {
                    saida = new ProvinciaViewModel()
                    {
                        Ativo = provincia.Ativo,
                        Cidades = CidadeViewModel.Mapear(provincia.Cidades),
                        CodigoISO = provincia.CodigoISO,
                        ID = provincia.ID,
                        ImpostoPermitido = provincia.ImpostoPermitido,
                        Nome = provincia.Nome,
                        Pais = PaisViewModel.Mapear(provincia.Pais)
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<ProvinciaViewModel> Mapear(ICollection<Provincia> provincias)
        {
            try
            {
                var saida = new Collection<ProvinciaViewModel>();
                if (provincias != null)
                {
                    foreach (var item in provincias)
                    {
                        var provincia = Mapear(item);
                        saida.Add(provincia);
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
