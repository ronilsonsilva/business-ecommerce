using SCommerce.b2SalesFashion.ViewModels;
using SCommerce.Domain.Entities.OC;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace bCommerce.b2SalesFashion.ViewModels
{
    public class OCStatusViewModel : BaseViewModels
    {
        public Boolean Faturado { get; set; }
        public Boolean EnviarEmail { get; set; }
        public Boolean NaoRemovivel { get; set; }
        public Boolean Oculto { get; set; }
        public Boolean Logable { get; set; }
        public Boolean Entregado { get; set; }
        public Boolean Enviado { get; set; }
        public Boolean Pago { get; set; }
        public Boolean Deletado { get; set; }
        public Boolean Cancelado { get; set; }
        public String ModuloNome { get; set; }
        public String Cor { get; set; }

        public ICollection<OCViewModel> OCs { get; set; }

        public static OCStatusViewModel Mapear(OCStatus oCStatus)
        {
            try
            {
                var saida = new OCStatusViewModel();
                if (oCStatus != null)
                {
                    saida = new OCStatusViewModel()
                    {
                        Cancelado = oCStatus.Cancelado,
                        Cor = oCStatus.Cor,
                        Deletado = oCStatus.Deletado,
                        Entregado = oCStatus.Entregado,
                        Enviado = oCStatus.Enviado,
                         EnviarEmail= oCStatus.EnviarEmail,
                         Faturado = oCStatus.Faturado,
                        ID = oCStatus.ID,
                        Logable = oCStatus.Logable,
                        ModuloNome = oCStatus.ModuloNome,
                        NaoRemovivel = oCStatus.NaoRemovivel,
                        OCs = OCViewModel.Mapear(oCStatus.OCs.ToList()),
                        Oculto = oCStatus.Oculto,
                        Pago = oCStatus.Pago
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ICollection<OCStatusViewModel> Mapear(ICollection<OCStatus> oCStatuses)
        {
            try
            {
                var saida = new Collection<OCStatusViewModel>();
                if (oCStatuses != null)
                {
                    foreach (var item in oCStatuses)
                    {
                        var ocStatus = Mapear(item);
                        saida.Add(ocStatus);
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
