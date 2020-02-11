//using System;
//using System.Collections.Generic;
//using System.Text;
//using SCommerce.Domain.Entities.Financeiro;

//namespace SCommerce.Domain.Entities.OC
//{
//    public class OCCarrinhoRegra : Base
//    {
//        public OCCarrinhoRegra(Guid ID)
//            : base(ID)
//        {

//        }
//        public OCCarrinhoRegra(OC oC, CarrinhoRegra carrinhoRegra, OCPedido oCPedido, string nome, decimal valor, decimal impostoExclusao, bool envioGratis, DateTime cadastro, DateTime atualizado)
//        {
//            OC = oC;
//            CarrinhoRegra = carrinhoRegra;
//            OCPedido = oCPedido;
//            Nome = nome;
//            Valor = valor;
//            ImpostoExclusao = impostoExclusao;
//            EnvioGratis = envioGratis;
//            Cadastro = cadastro;
//            Atualizado = atualizado;
//        }

//        public Guid OCId { get; set; }
//        public OC OC { get;  set; }

//        public Financeiro.CarrinhoRegra CarrinhoRegra { get;  set; }
//        public OCPedido OCPedido { get;  set; }
//        public String Nome { get;  set; }
//        public Decimal Valor { get;  set; }
//        public Decimal ImpostoExclusao { get;  set; }
//        public Boolean EnvioGratis { get;  set; }
//        public DateTime Cadastro { get;  set; }
//        public DateTime Atualizado { get;  set; }
//    }
//}
