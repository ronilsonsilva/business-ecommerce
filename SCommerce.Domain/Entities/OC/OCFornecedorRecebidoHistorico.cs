//using System;
//using System.Collections.Generic;
//using System.Text;
//using SCommerce.Domain.Entities.Empregado;

//namespace SCommerce.Domain.Entities.OC
//{
//    public class OCFornecedorRecebidoHistorico : Base
//    {
//        public OCFornecedorRecebidoHistorico()
//        {

//        }
//        public OCFornecedorRecebidoHistorico(OCFornecedorDetalhes oCFornecedorDetalhes, Empregado.Empregado empregado, OCFornecedorEstado oCFornecedorEstado, int quantidade, DateTime cadastro, DateTime atualizado)
//        {
//            OCFornecedorDetalhes = oCFornecedorDetalhes;
//            Empregado = empregado;
//            OCFornecedorEstado = oCFornecedorEstado;
//            Quantidade = quantidade;
//            Cadastro = cadastro;
//            Atualizado = atualizado;
//        }

//        public OCFornecedorDetalhes OCFornecedorDetalhes { get;  set; }
//        public Empregado.Empregado Empregado { get;  set; }
//        public OCFornecedorEstado OCFornecedorEstado { get;  set; }
//        public int Quantidade { get;  set; }
//        public DateTime Cadastro { get;  set; }
//        public DateTime Atualizado { get;  set; }
//    }
//}
