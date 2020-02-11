using SCommerce.b2SalesFashion.ViewModels;
using SCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bCommerce.b2SalesFashion.ViewModels
{
    public class CarrinhoViewModel : Base
    {
        public CarrinhoViewModel(Guid ID) : base(ID)
        {
        }

        [Display(Name = "Opção de Envio")]
        public String OpcaoEnvio { get; set; }

        [Display(Name = "Chave de Segurança")]
        public String ChaveSeguranca { get; set; }

        [Display(Name = "Produto Reciclável")]
        public Boolean Reciclavel { get; set; }

        [Display(Name = "Permite Pacote Separado")]
        public Boolean PermitirPacoteSeparado { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime Cadastro { get; set; }

        [Display(Name = "Ùltima Atualização")]
        public DateTime Atualizado { get; set; }

        [Display(Name = "Cliente")]
        public Guid IdCliente { get; set; }

        [Display(Name = "Cliente")]
        public ClienteViewModel Cliente { get; set; }

        [Display(Name = "Loja")]
        public Guid IdLoja { get; set; }

        [Display(Name = "Loja")]
        public LojaHomeViewModel Loja { get; set; }

        public ICollection<CarrinhoProdutoViewModel> CarrinhoProdutos { get; set; }

        public static CarrinhoViewModel Mapear(SCommerce.Domain.Entities.Carrinho.Carrinho carrinho)
        {
            var saida = new CarrinhoViewModel(Guid.Empty);
            if (carrinho != null)
            {
                saida = new CarrinhoViewModel(carrinho.ID)
                {
                    Atualizado = carrinho.Atualizado,
                    Cadastro = carrinho.Cadastro,
                    ChaveSeguranca = carrinho.ChaveSeguranca,
                    Cliente = ClienteViewModel.Mapear(carrinho?.Cliente),
                    IdCliente = carrinho.IdCliente,
                    IdLoja = carrinho.IdLoja,
                    OpcaoEnvio = carrinho.OpcaoEnvio,
                    PermitirPacoteSeparado = carrinho.PermitirPacoteSeparado,
                    Reciclavel = carrinho.Reciclavel,
                    CarrinhoProdutos = CarrinhoProdutoViewModel.Mapear(carrinho.CarrinhoProdutos)
                };
            }
            return saida;
        }

        public static ICollection<CarrinhoViewModel> Mapear(ICollection<SCommerce.Domain.Entities.Carrinho.Carrinho> carrinhos)
        {
            var saida = new Collection<CarrinhoViewModel>();
            if (carrinhos != null)
            {
                foreach (var item in carrinhos)
                {
                    var carrinho = Mapear(item);
                    saida.Add(carrinho);
                }
            }
            return saida;
        }

    }
}
