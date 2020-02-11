using SCommerce.Domain.Entities.Produto;
using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class ProdutoImagemViewModel : BaseViewModels
    {
        [Display(Name = "Produto")]
        public Guid IdProduto { get; set; }

        [Display(Name = "Produto")]
        public ProdutoViewModel Produto { get; set; }

        [Display(Name = "Arquivo")]
        [DataType(DataType.Upload)]
        public Byte[] Arquivo { get; set; }

        [Display(Name = "Formato")]
        public String Formato { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        public DateTime Cadastro { get; set; }

        [Display(Name = "Última Atualização")]
        [DataType(DataType.DateTime)]
        public DateTime Atualizada { get; set; }


        public static ProdutoImagemViewModel Mapear(ProdutoImagem produtoImagem)
        {
            try
            {
                ProdutoImagemViewModel saida = new ProdutoImagemViewModel();
                if (produtoImagem != null)
                {
                    saida = new ProdutoImagemViewModel()
                    {
                        Arquivo = produtoImagem.Arquivo,
                        Atualizada = produtoImagem.Atualizada,
                        Cadastro = produtoImagem.Cadastro,
                        Formato = produtoImagem.Formato,
                        ID = produtoImagem.ID,
                        IdProduto = produtoImagem.IdProduto
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<ProdutoImagemViewModel> Mapear(ICollection<ProdutoImagem> produtoImagens)
        {
            try
            {
                Collection<ProdutoImagemViewModel> saida = new Collection<ProdutoImagemViewModel>();
                if (produtoImagens != null)
                {
                    foreach (var item in produtoImagens)
                    {
                        var produtoImagem = Mapear(item);
                        saida.Add(produtoImagem);
                    }
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ProdutoImagem Mapear(ProdutoImagemViewModel produtoImagem)
        {
            try
            {
                ProdutoImagem saida = new ProdutoImagem(Guid.Empty);
                if (produtoImagem != null)
                {
                    saida = new ProdutoImagem(Guid.Empty)
                    {
                        Arquivo = produtoImagem.Arquivo,
                        Atualizada = produtoImagem.Atualizada,
                        Cadastro = produtoImagem.Cadastro,
                        Formato = produtoImagem.Formato,
                        ID = produtoImagem.ID,
                        IdProduto = produtoImagem.IdProduto
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<ProdutoImagem> Mapear(ICollection<ProdutoImagemViewModel> produtoImagens)
        {
            try
            {
                Collection<ProdutoImagem> saida = new Collection<ProdutoImagem>();
                if (produtoImagens != null)
                {
                    foreach (var item in produtoImagens)
                    {
                        var produtoImagem = Mapear(item);
                        saida.Add(produtoImagem);
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
