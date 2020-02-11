using Microsoft.AspNetCore.Http.Internal;
using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class CMSEnderecoLojaViewModel : BaseViewModels
    {
        [Display(Name = "Observação")]
        public String Observacao { get; set; }

        [Display(Name = "Tipo do Arquivo")]
        public String ImagemType { get; set; }

        [Display(Name = "Imagem")]
        public Byte[] Imagem { get; set; }

        [Display(Name = "Imagem")]
        public FormFile ArquivoImagem { get; set; }

        [Display(Name = "Latitude")]
        public Decimal Latitute { get; set; }

        [Display(Name = "Longitude")]
        public Decimal Longitude { get; set; }

        [Display(Name = "Exibir Localização")]
        public Boolean ExibirMapa { get; set; }

        [Display(Name = "Endereco")]
        public Guid IdContatoLojaEndereco { get; set; }
        public ContatoLojaEnderecoViewModel ContatoLojaEndereco { get; set; }
    }
}
