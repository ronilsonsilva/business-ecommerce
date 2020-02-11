using SCommerce.b2SalesFashion.ViewModels;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace bCommerce.b2SalesFashion.ViewModels
{
    public class AnexoViewModel : BaseViewModels
    {
        public String Nome { get; set; }
        public String Tipo { get; set; }
        public Byte[] Arquivo { get; set; }
        public Guid IdOCMensagem { get; set; }
        public OCMensagemViewModel OCMensagems { get; set; }

        public static AnexoViewModel Mapear(Anexo anexo)
        {
            try
            {
                var saida = new AnexoViewModel();
                if (anexo != null)
                {
                    saida = new AnexoViewModel()
                    {
                        Arquivo = anexo.Arquivo,
                        ID = anexo.ID,
                        IdOCMensagem = anexo.IdOCMensagem,
                        Nome = anexo.Nome,
                        OCMensagems = OCMensagemViewModel.Mapear(anexo.OCMensagems),
                        Tipo = anexo.Tipo
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<AnexoViewModel> Mapear(ICollection<Anexo> anexos)
        {
            try
            {
                var saida = new Collection<AnexoViewModel>();
                if (anexos != null)
                {
                    foreach (var item in anexos)
                    {
                        var anexo = Mapear(item);
                        saida.Add(anexo);
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
