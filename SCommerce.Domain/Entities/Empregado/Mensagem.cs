//using System;
//using System.Collections.Generic;
//using System.Text;
//using SCommerce.Domain.Entities.CadastroBase;
//using SCommerce.Domain.Entities.Cliente;
//using SCommerce.Domain.Entities.Financeiro;
//using SCommerce.Domain.Entities.OC;

//namespace SCommerce.Domain.Entities.Empregado
//{
//    public class Mensagem : Base
//    {
//        public Mensagem(Guid ID)
//            : base(ID)
//        {

//        }
        
//        //public Guid CarrinhoId { get; set; }
//        //public Guid ClienteId { get; set; }
//        //public Guid EmpregadoId { get; set; }
//        //public Guid OCId { get; set; }
//        public Carrinho.Carrinho Carrinho { get;  set; }
//        public Cliente.Cliente Cliente { get;  set; }
//        public Empregado Empregado { get;  set; }
//        public OC.OC OC { get;  set; }
//        public String Texto { get;  set; }
//        public Boolean Privada { get;  set; }
//        public Boolean Lida { get;  set; }
//        public DateTime Data { get;  set; }
//        public ICollection<CadastroBase.ArquivoMensagem> Arquivos { get;  set; }
//    }
//}
