//using System;
//using System.Collections.Generic;
//using System.Text;
//using SCommerce.Domain.Entities.Empregado;
//using SCommerce.Domain.Entities.OC;

//namespace SCommerce.Domain.Entities.Estoque
//{
//    public class EstoqueMovimento : Base
//    {
//        public EstoqueMovimento(Guid ID)
//            : base(ID)
//        {

//        }
//        //public Guid EstoqueMovimentoProdutosId { get; set; }
//        //public Guid EstoqueId { get;  set; }
//        //public Guid OCId { get;  set; }
//        //public Guid OCFornecedorId { get;  set; }
//        //public Guid EstoqueMovimentoRazaoId { get;  set; }
//        //public Guid EmpregadoId { get;  set; }
//        public int QuantidadeFisica { get;  set; }
//        public DateTime Data { get;  set; }
//        public Boolean Sign { get;  set; }
//        public Decimal PriceTe { get;  set; }
//        public Decimal LastWa { get;  set; }
//        public Decimal CurrentWa { get;  set; }
//        public int Referencia { get;  set; }

//        public Estoque Estoque { get;  set; }
//        public OC.OC OC { get;  set; }
//        //public OC.OCFornecedor OCFornecedor { get;  set; }
//        public EstoqueMovimentoRazao EstoqueMovimentoRazao { get;  set; }
//        public ICollection<EstoqueMovimentoProdutos> EstoqueMovimentoProdutos { get;  set; }
//        public Empregado.Empregado Empregado { get;  set; }
//    }
//}
