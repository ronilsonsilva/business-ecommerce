using SCommerce.b2SalesFashion.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bCommerce.b2SalesFashion.ViewModels
{
    public class DashboardCliente
    {
        public ClienteViewModel Cliente { get; set; }
        public CarrinhoViewModel Carrinho { get; set; }
        public List<OCViewModel> OCs { get; set; }
        public List<OCMensagemViewModel> oCMensagens { get; set; }
    }
}
