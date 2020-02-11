//using System;
//using System.Collections.Generic;
//using System.Text;
//using SCommerce.Domain.Entities.CadastroBase;
//using SCommerce.Domain.Enum;

//namespace SCommerce.Domain.Entities.Financeiro
//{
//    public class PrecoEspecificoRegra : Base
//    {
//        public PrecoEspecificoRegra(Guid ID)
//            : base(ID)
//        {

//        }
       
//        public String Nome { get;  set; }
//        //public Guid LojaId { get; set; }
//        //public Guid PaisId { get; set; }
//        //public Guid MoedaId { get; set; }
//        //public Guid GrupoId { get; set; }
//        public CadastroBase.Loja Loja { get;  set; }
//        public CadastroBase.Pais Pais { get;  set; }
//        public Moeda Moeda { get;  set; }
//        public CadastroBase.Grupo Grupo { get;  set; }
//        public Decimal ApartirQuantidade { get;  set; }
//        public Decimal Desconto { get;  set; }
//        public Decimal Preco { get;  set; }
//        public Enum.TipoDesconto Tipo { get; set; }
//        public DateTime DataInicio { get;  set; }
//        public DateTime DataFim { get;  set; }
//        public DateTime Cadastro { get;  set; }
//        public DateTime Atualizado { get;  set; }
//    }
//}
