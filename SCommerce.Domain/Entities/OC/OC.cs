using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Carrinho;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Entities.Financeiro;
using SCommerce.Domain.Entities.Transportadora;

namespace SCommerce.Domain.Entities.OC
{
    public class OC : Base
    {
        public OC(Guid ID)
            : base(ID)
        {

        }
        
        public String Referencia { get;  set; }
        public String NumeroEnvio { get;  set; }
        public Decimal DescontoTotal { get;  set; }
        public Decimal PagamentoTotal { get;  set; }
        public Decimal PagamentoReal { get;  set; }
        public Decimal ProdutoTotal { get;  set; }
        public Decimal TotalEnviado { get;  set; }
        public DateTime DataEnvio { get;  set; }
        public Boolean Valido { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }

        public Guid? IdMetotoPagamento { get; set; }
        public MetodoPagamento MetodoPagamento { get;  set; }
        public Guid? IdLoja { get; set; }
        public Loja Loja { get; set; }
        public Guid? IdCliente { get; set; }
        public Cliente.Cliente Cliente { get; set; }
        public Guid? IdOCStatus { get; set; }
        public OCStatus OCStatus { get; set; }

        public ICollection<OCFatura> OCFaturas { get; set; }
        public ICollection<Empregado.EmpregadoOC> EmpregadoOCs { get; set; }
        public ICollection<ClienteProcesso> ClienteProcessos { get; set; }
        public ICollection<OCDetalhes> OCDetalhes { get; set; }
        public ICollection<OCMensagem> OCMensagens { get; set; }
        public ICollection<Entrega> Entregas { get; set; }
    }
}
