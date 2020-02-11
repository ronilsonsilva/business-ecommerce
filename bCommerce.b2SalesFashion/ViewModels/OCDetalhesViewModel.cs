using SCommerce.b2SalesFashion.ViewModels;
using SCommerce.Domain.Entities.OC;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace bCommerce.b2SalesFashion.ViewModels
{
    public class OCDetalhesViewModel : BaseViewModels
    {
        public int Quantidade { get; set; }
        public String Observacao { get; set; }

        public Guid IdOC { get; set; }
        public OCViewModel OC { get; set; }
        public Guid IdProduto { get; set; }
        public ProdutoViewModel Produto { get; set; }

        public static OCDetalhesViewModel Mapear(OCDetalhes oCDetalhes)
        {
            try
            {
                var saida = new OCDetalhesViewModel();
                if (oCDetalhes != null)
                {
                    saida = new OCDetalhesViewModel()
                    {
                        ID = oCDetalhes.ID,
                        IdOC = oCDetalhes.IdOC,
                        IdProduto = oCDetalhes.IdProduto,
                        Observacao = oCDetalhes.Observacao,
                        OC = OCViewModel.Mapear(oCDetalhes.OC),
                        Produto = ProdutoViewModel.Mapear(oCDetalhes.Produto),
                        Quantidade = oCDetalhes.Quantidade
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<OCDetalhesViewModel> Mapear(ICollection<OCDetalhes> oCDetalhes)
        {
            try
            {
                var saida = new Collection<OCDetalhesViewModel>();
                if (oCDetalhes != null)
                {
                    foreach (var item in oCDetalhes)
                    {
                        var ocDetalhes = Mapear(item);
                        saida.Add(ocDetalhes);
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
