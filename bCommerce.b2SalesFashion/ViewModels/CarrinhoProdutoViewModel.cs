using SCommerce.b2SalesFashion.ViewModels;
using SCommerce.Domain.Entities;
using SCommerce.Domain.Entities.Carrinho;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bCommerce.b2SalesFashion.ViewModels
{
    public class CarrinhoProdutoViewModel : Base
    {
        public CarrinhoProdutoViewModel(Guid ID) : base(ID)
        {
        }

        [Display(Name = "Carrinho")]
        public Guid IdCarrinho { get; set; }

        [Display(Name = "Carrinho")]
        public CarrinhoViewModel Carrinho { get; set; }

        [Display(Name = "Produto")]
        public Guid IdProduto { get; set; }

        [Display(Name = "Produto")]
        public ProdutoViewModel Produto { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime Cadastro { get; set; }

        [Display(Name = "Ùltima Atualização")]
        public DateTime Atualizado { get; set; }

        public static CarrinhoProdutoViewModel Mapear(CarrinhoProduto carrinhoProduto)
        {
            try
            {
                var saida = new CarrinhoProdutoViewModel(Guid.Empty);
                if (carrinhoProduto != null)
                {
                    saida = new CarrinhoProdutoViewModel(carrinhoProduto.ID)
                    {
                        Atualizado = carrinhoProduto.Atualizado,
                        Cadastro = carrinhoProduto.Cadastro,
                        IdCarrinho = carrinhoProduto.IdCarrinho,
                        IdProduto = carrinhoProduto.IdProduto,
                        Quantidade = carrinhoProduto.Quantidade,
                        Produto = ProdutoViewModel.Mapear(carrinhoProduto.Produto)
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<CarrinhoProdutoViewModel> Mapear(ICollection<CarrinhoProduto> carrinhoProdutos)
        {
            try
            {
                var saida = new Collection<CarrinhoProdutoViewModel>();
                if (carrinhoProdutos != null)
                {
                    foreach (var item in carrinhoProdutos)
                    {
                        var carrinhoProduto = Mapear(item);
                        saida.Add(carrinhoProduto);
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
