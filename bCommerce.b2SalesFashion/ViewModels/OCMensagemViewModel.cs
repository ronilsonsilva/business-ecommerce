using SCommerce.b2SalesFashion.ViewModels;
using SCommerce.Domain.Entities.OC;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace bCommerce.b2SalesFashion.ViewModels
{
    public class OCMensagemViewModel : BaseViewModels
    {
        public DateTime Data { get; set; }
        public Boolean Lida { get; set; }
        public Boolean Privada { get; set; }
        public String Mensagem { get; set; }

        public Guid IdOC { get; set; }
        public OCViewModel OC { get; set; }
        public Guid idEmitente { get; set; }
        public ICollection<AnexoViewModel> Anexos { get; set; }

        public static OCMensagemViewModel Mapear(OCMensagem oCMensagem)
        {
            try
            {
                var saida = new OCMensagemViewModel();
                if (oCMensagem != null)
                {
                    saida = new OCMensagemViewModel()
                    {
                        Anexos = AnexoViewModel.Mapear(oCMensagem.Anexos),
                        Data = oCMensagem.Data,
                        ID = oCMensagem.ID,
                        IdOC = oCMensagem.IdOC,
                        Lida = oCMensagem.Lida,
                        Mensagem = oCMensagem.Mensagem,
                        OC = OCViewModel.Mapear(oCMensagem.OC),
                        Privada = oCMensagem.Privada,
                        idEmitente = oCMensagem.idEmitente
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<OCMensagemViewModel> Mapear(ICollection<OCMensagem> oCMensagens)
        {
            try
            {
                var saida = new Collection<OCMensagemViewModel>();
                if (oCMensagens != null)
                {
                    foreach (var item in oCMensagens)
                    {
                        var entidade = Mapear(item);
                        saida.Add(entidade);
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
