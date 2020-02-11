using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.CMS;
using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class CMSLojaViewModel : BaseViewModels
    {
        [Display(Name = "Loja")]
        public Guid IdLoja { get; set; }
        public LojaViewModel Loja { get; set; }

        [Display(Name = "Tipo de Arquivo")]
        public String IconeType { get; set; }

        [Display(Name = "Ícone do site")]
        public Byte[] Icone { get; set; }

        [Display(Name = "Ícone do site")]
        public IFormFile ArquivoIcone { get; set; }

        [Display(Name = "Tipo do Arquivo")]
        public String LogoType { get; set; }

        [Display(Name = "Branch 1")]
        public Byte[] Logo { get; set; }

        [Display(Name = "Branch 1")]
        public IFormFile ArquivoLog_1 { get; set; }

        [Display(Name = "Tipo do Arquivo")]
        public String LogoType2 { get; set; }

        [Display(Name = "Branch 2")]
        public Byte[] Logo2 { get; set; }

        [Display(Name = "Branch 2")]
        public IFormFile ArquivoLog_2 { get; set; }

        public static CMSLojaViewModel Mapear(Domain.Entities.CMS.CMSLoja cmsLoja)
        {
            var saida = new CMSLojaViewModel();
            if (cmsLoja != null)
            {
                saida = new CMSLojaViewModel()
                {
                    Icone = cmsLoja.Icone,
                    IconeType = cmsLoja.IconeType,
                    ID = cmsLoja.ID,
                    IdLoja = cmsLoja.IdLoja,
                    Logo = cmsLoja.Logo,
                    Logo2 = cmsLoja.Logo2,
                    LogoType = cmsLoja.LogoType,
                    LogoType2 = cmsLoja.LogoType2
                };
            }
            if (saida.Loja == null)
            {
                saida.Loja = new LojaViewModel();
            }
            saida.Loja = LojaViewModel.Mapear(cmsLoja.Loja);
            return saida;
        }

        public static ICollection<CMSLojaViewModel> Mapear(ICollection<Domain.Entities.CMS.CMSLoja> cmsLoja)
        {
            var saida = new Collection<CMSLojaViewModel>();
            if (cmsLoja != null)
            {
                foreach (var item in cmsLoja)
                {
                    saida.Add(CMSLojaViewModel.Mapear(item));
                }
            }
            return saida;
        }

        public static CMSLoja Mapear(CMSLojaViewModel cmsLoja)
        {
            var saida = new CMSLoja(Guid.Empty);
            if (cmsLoja != null)
            {
                saida = new CMSLoja(Guid.Empty)
                {
                    Icone = cmsLoja.Icone,
                    IconeType = cmsLoja.IconeType,
                    ID = cmsLoja.ID,
                    IdLoja = cmsLoja.IdLoja,
                    Logo = cmsLoja.Logo,
                    Logo2 = cmsLoja.Logo2,
                    LogoType = cmsLoja.LogoType,
                    LogoType2 = cmsLoja.LogoType2
                };
            }
            if (saida.Loja == null)
            {
                saida.Loja = new Loja(Guid.Empty);
            }
            saida.Loja = LojaViewModel.Mapear(cmsLoja.Loja);
            return saida;
        }

        public static ICollection<CMSLoja> Mapear(ICollection<CMSLojaViewModel> cmsLoja)
        {
            var saida = new Collection<CMSLoja>();
            if (cmsLoja != null)
            {
                foreach (var item in cmsLoja)
                {
                    saida.Add(CMSLojaViewModel.Mapear(item));
                }
            }
            return saida;
        }
    }
}
