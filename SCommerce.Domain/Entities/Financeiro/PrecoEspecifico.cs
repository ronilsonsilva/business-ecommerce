//using SCommerce.Domain.Entities.CadastroBase;
//using SCommerce.Domain.Entities.Carrinho;
//using SCommerce.Domain.Entities.Cliente;
//using SCommerce.Domain.Entities.Produto;
//using SCommerce.Domain.Enum;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Domain.Entities.Financeiro
//{
//    public class PrecoEspecifico : Base
//    {
//        public PrecoEspecifico(Guid ID)
//            : base(ID)
//        {

//        }
        
//        //public PrecoEspecificoRegra PrecoEspecificoRegra { get;  set; }
//        //public Guid CarrinhoId { get; set; }
//        public Carrinho.Carrinho Carrinho { get;  set; }
//        //public Guid LojaId { get; set; }
//        //public Guid ProdutoId { get; set; }
//        public CadastroBase.Loja Loja { get;  set; }
//        public Produto.Produto Produto { get;  set; }
//        //public Guid LojaGrupoId { get; set; }
//        //public Guid MoedaId { get; set; }
//        public CadastroBase.LojaGrupo LojaGrupo { get;  set; }
//        public Moeda Moeda { get;  set; }
//        //public Guid PaisId { get; set; }
//        //public Guid GrupoId { get; set; }
//        //public Guid ClienteId { get; set; }
//        public CadastroBase.Pais Pais { get;  set; }
//        public CadastroBase.Grupo Grupo { get;  set; }
//        public Cliente.Cliente Cliente { get;  set; }
//        public Decimal Preco { get;  set; }
//        public int ApartirQuantidade { get;  set; }
//        public Decimal Desconto { get;  set; }
//        public Enum.TipoDesconto Tipo { get;  set; }
//        public DateTime DataInicio { get; set; }
//        public DateTime DataFim { get; set; }
//        public DateTime Cadastro { get; set; }
//        public DateTime Atualizado { get; set; }
//    }
//}
