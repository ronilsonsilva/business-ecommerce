using SCommerce.b2SalesFashion.ViewModels;
using SCommerce.Domain.Entities.Financeiro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace bCommerce.b2SalesFashion.ViewModels
{
    public class MetodoPagamentoViewModel : BaseViewModels
    {
        public String Nome { get; set; }
        public String Observacao { get; set; }
        public ICollection<OCViewModel> OCs { get; set; }

        public static MetodoPagamentoViewModel Mapear(MetodoPagamento metodoPagamento)
        {
            try
            {
                var saida = new MetodoPagamentoViewModel();
                if (metodoPagamento != null)
                {
                    saida = new MetodoPagamentoViewModel()
                    {
                        ID = metodoPagamento.ID,
                        Nome = metodoPagamento.Nome,
                        Observacao =metodoPagamento.Observacao,
                        OCs = OCViewModel.Mapear(metodoPagamento.OCs.ToList())
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<MetodoPagamentoViewModel> Mapear(ICollection<MetodoPagamento> metodoPagamentos)
        {
            try
            {
                var saida = new Collection<MetodoPagamentoViewModel>();
                if (metodoPagamentos != null)
                {
                    foreach (var item in metodoPagamentos)
                    {
                        var metodoPagamento = Mapear(item);
                        saida.Add(metodoPagamento);
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
