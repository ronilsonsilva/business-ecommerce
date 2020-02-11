using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Entities.Financeiro;
using SCommerce.Domain.Entities.Transportadora;

namespace SCommerce.Domain.Entities.Carrinho
{
    public class Carrinho : Base
    {
        public Carrinho(Guid ID)
            : base(ID)
        {

        }

        public String OpcaoEnvio { get; set; }
        public String ChaveSeguranca { get; set; }
        public Boolean Reciclavel { get; set; }
        public Boolean PermitirPacoteSeparado { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime Atualizado { get; set; }

        public Guid IdCliente { get; set; }
        public Cliente.Cliente Cliente { get; set; }
        public Guid IdLoja { get; set; }
        public CadastroBase.Loja Loja { get; set; }
        public Boolean GerarOC { get; set; }

        public ICollection<CarrinhoProduto> CarrinhoProdutos { get; set; }
    }
}
