using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class CMSRedeSocialViewModel : BaseViewModels
    {
        [Display(Name = "Loja")]
        public Guid IdLoja { get; set; }
        public LojaViewModel Loja { get; set; }

        [Display(Name = "Nome da Rede Social")]
        public String Nome { get; set; }

        [Display(Name = "Tipo do Arquivo")]
        public String IconeType { get; set; }

        [Display(Name = "Ícone")]
        public Byte[] Icone { get; set; }

        [Display(Name = "Ícone")]
        public IFormFile ArquivoIcone { get; set; }

        [Display(Name = "Link")]
        public String Url { get; set; }
    }
}
