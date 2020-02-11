//using System;
//using System.Collections.Generic;
//using System.Text;
//using SCommerce.Domain.Entities.Cliente;
//using SCommerce.Domain.Entities.Empregado;
//using SCommerce.Domain.Entities.Financeiro;
//using SCommerce.Domain.Enum;

//namespace SCommerce.Domain.Entities.Deposito
//{
//    public class Deposito : Base
//    {
//        public Deposito(Guid ID)
//            : base(ID)
//        {

//        }
        
//        public String Referencia { get;  set; }
//        public String Nome { get;  set; }
//        public Enum.TipoGerenciamento TipoGerenciamento { get;  set; }
//        public Boolean Deletado { get;  set; }
//        //public Guid MoedaId { get; set; }
//        public Financeiro.Moeda Moeda { get;  set; }
//        public ICollection<DepositoEndereco> DepositoEnderecos { get;  set; }
//        public ICollection<DepositoProduto> DepositoProdutos { get;  set; }
//        public ICollection<DepositoEmpregado> Empregados { get;  set; }
//    }
//}
