//using System;
//using System.Collections.Generic;
//using System.Text;
//using SCommerce.Domain.Entities.CadastroBase;

//namespace SCommerce.Domain.Entities.Produto
//{
//    public class DisponivelEstoque : Base
//    {
//        public DisponivelEstoque(Guid ID)
//            : base(ID)
//        {

//        }
//        public DisponivelEstoque(Produto produto, ProdutoAtributo produtoAtributo, Loja loja, LojaGrupo lojaGrupo, int quantidade, bool dependeEstoque, bool foraDeEstoque)
//        {
//            Produto = produto;
//            ProdutoAtributo = produtoAtributo;
//            Loja = loja;
//            LojaGrupo = lojaGrupo;
//            Quantidade = quantidade;
//            DependeEstoque = dependeEstoque;
//            ForaDeEstoque = foraDeEstoque;
//        }

//        public Produto Produto { get;  set; }
//        public ProdutoAtributo ProdutoAtributo { get;  set; }
//        public CadastroBase.Loja Loja { get;  set; }
//        public CadastroBase.LojaGrupo LojaGrupo { get;  set; }
//        public int Quantidade { get;  set; }
//        public Boolean DependeEstoque { get;  set; }
//        public Boolean ForaDeEstoque { get;  set; }
//    }
//}
