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
    public class CMSSlidePrincipalViewModel : BaseViewModels
    {
        [Display(Name = "Tipo do Arquivo")]
        public String ArquivoType { get; set; }

        [Display(Name = "Arquivo")]
        public Byte[] ArquivoImage { get; set; }

        [Display(Name = "Imagem")]
        public IFormFile ArquivoImagem { get; set; }

        [Display(Name = "Data de Inicio")]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Data Final")]
        public DateTime DataFinal { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime Cadastro { get; set; }

        [Display(Name = "Atualizado em")]
        public DateTime Atualizado { get; set; }

        [Display(Name = "Titulo Principal")]
        public string TituloPrincipal { get; set; }

        [Display(Name = "Subtitulo")]
        public string Subtitulo { get; set; }

        [Display(Name = "Link de Produto")]
        public Boolean Produto { get; set; }

        [Display(Name = "Link de Categoria")]
        public Boolean Categoria { get; set; }

        [Display(Name = "Produto")]
        public Guid IdProduto { get; set; }

        [Display(Name = "Produtos")]
        public ICollection<ProdutoViewModel> Produtos { get; set; }

        [Display(Name = "Categoria")]
        public Guid IdCategoria { get; set; }

        [Display(Name = "Categorias")]
        public ICollection<CategoriaViewModel> Categorias { get; set; }

        public ICollection<CMSSlidePrincipalViewModel> Slides { get; set; }

    }
}
