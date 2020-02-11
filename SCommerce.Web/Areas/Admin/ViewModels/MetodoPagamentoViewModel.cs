using SCommerce.Domain.Entities.Financeiro;
using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class MetodoPagamentoViewModel : BaseViewModels
    {
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Observações")]
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
                        Observacao = metodoPagamento.Observacao
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

        public static MetodoPagamento Mapear(MetodoPagamentoViewModel metodoPagamento)
        {
            try
            {
                var saida = new MetodoPagamento(Guid.Empty);
                if (metodoPagamento != null)
                {
                    saida = new MetodoPagamento(Guid.Empty)
                    {
                        ID = metodoPagamento.ID,
                        Nome = metodoPagamento.Nome,
                        Observacao = metodoPagamento.Observacao
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<MetodoPagamento> Mapear(ICollection<MetodoPagamentoViewModel> metodoPagamentos)
        {
            try
            {
                var saida = new Collection<MetodoPagamento>();
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
