//using System;
//using System.Collections.Generic;
//using System.Text;
//using SCommerce.Domain.Entities.Deposito;
//using SCommerce.Domain.Entities.Financeiro;
//using SCommerce.Domain.Entities.Fornecedor;

//namespace SCommerce.Domain.Entities.OC
//{
//    public class OCFornecedor : Base
//    {
//        public OCFornecedor(Guid ID)
//            : base(ID)
//        {

//        }
//        public OCFornecedor(Fornecedor.Fornecedor fornecedor, Deposito.Deposito deposito, OCFornecedorEstado oCFornecedorEstado, Moeda moeda, string referencia, DateTime cadastro, DateTime atualizado, DateTime expecatativaEnvio, decimal totalTe, decimal totalComDesconto, decimal totalImposto, decimal totalTi, decimal taxaDescontada, decimal discountValueTe, bool template)
//        {
//            Fornecedor = fornecedor;
//            Deposito = deposito;
//            OCFornecedorEstado = oCFornecedorEstado;
//            Moeda = moeda;
//            Referencia = referencia;
//            Cadastro = cadastro;
//            Atualizado = atualizado;
//            ExpecatativaEnvio = expecatativaEnvio;
//            TotalTe = totalTe;
//            TotalComDesconto = totalComDesconto;
//            TotalImposto = totalImposto;
//            TotalTi = totalTi;
//            TaxaDescontada = taxaDescontada;
//            DiscountValueTe = discountValueTe;
//            Template = template;
//        }

//        public Guid FornecedorId { get; set; }
//        public Guid DepositoId { get; set; }
//        public Guid OCFornecedorEstadoId { get; set; }
//        public Guid MoedaId { get; set; }
//        public Fornecedor.Fornecedor Fornecedor { get;  set; }
//        public Deposito.Deposito Deposito { get;  set; }
//        public OCFornecedorEstado OCFornecedorEstado { get;  set; }
//        public Financeiro.Moeda Moeda { get;  set; }
//        public String Referencia { get;  set; }
//        public DateTime Cadastro { get;  set; }
//        public DateTime Atualizado { get;  set; }
//        public DateTime ExpecatativaEnvio { get;  set; }
//        public Decimal TotalTe { get;  set; }
//        public Decimal TotalComDesconto { get;  set; }
//        public Decimal TotalImposto { get;  set; }
//        public Decimal TotalTi { get;  set; }
//        public Decimal TaxaDescontada { get;  set; }
//        public Decimal DiscountValueTe { get;  set; }
//        public Boolean Template { get;  set; }
//    }
//}
