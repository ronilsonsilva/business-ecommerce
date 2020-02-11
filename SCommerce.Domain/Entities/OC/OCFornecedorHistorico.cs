//using System;
//using System.Collections.Generic;
//using System.Text;
//using SCommerce.Domain.Entities.Empregado;

//namespace SCommerce.Domain.Entities.OC
//{
//    public class OCFornecedorHistorico : Base
//    {
//        public OCFornecedorHistorico()
//        {

//        }
//        public OCFornecedorHistorico(OCFornecedor oCFornecedor, Empregado.Empregado empregado, OCFornecedorEstado status, DateTime cadastro, DateTime atualizado, string comentario)
//        {
//            OCFornecedor = oCFornecedor;
//            Empregado = empregado;
//            Status = status;
//            Cadastro = cadastro;
//            Atualizado = atualizado;
//            Comentario = comentario;
//        }

//        public OCFornecedor OCFornecedor { get;  set; }
//        public Empregado.Empregado Empregado { get;  set; }
//        public OCFornecedorEstado Status { get;  set; }
//        public DateTime Cadastro { get;  set; }
//        public DateTime Atualizado { get;  set; }
//        public String Comentario { get;  set; }
//    }
//}
