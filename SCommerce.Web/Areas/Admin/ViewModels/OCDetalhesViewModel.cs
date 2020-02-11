using SCommerce.Domain.Entities.OC;
using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
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

        public static OCDetalhes Mapear(OCDetalhesViewModel oCDetalhes)
        {
            try
            {
                var saida = new OCDetalhes(Guid.Empty);
                if (oCDetalhes != null)
                {
                    saida = new OCDetalhes(Guid.Empty)
                    {
                        ID = oCDetalhes.ID,
                        IdOC = oCDetalhes.IdOC,
                        IdProduto = oCDetalhes.IdProduto,
                        Observacao = oCDetalhes.Observacao,
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

        public static ICollection<OCDetalhes> Mapear(ICollection<OCDetalhesViewModel> oCDetalhes)
        {
            try
            {
                var saida = new Collection<OCDetalhes>();
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
