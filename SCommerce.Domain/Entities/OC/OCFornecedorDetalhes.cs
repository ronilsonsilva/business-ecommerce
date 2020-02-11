//using System;
//using System.Collections.Generic;
//using System.Text;
//using SCommerce.Domain.Entities.Financeiro;
//using SCommerce.Domain.Entities.Produto;

//namespace SCommerce.Domain.Entities.OC
//{
//    public class OCFornecedorDetalhes : Base
//    {
//        public OCFornecedorDetalhes()
//        {

//        }
//        public OCFornecedorDetalhes(OCFornecedor oCFornecedor, Moeda moeda, Produto.Produto produto, ProdutoAtributo produtoAtributo, string nome, string referencia, string referenciaFornecedor, string eAN13, string uPC, decimal taxaTroca, decimal precoUnitario, decimal preco, decimal precoComDesconto, decimal taxaImposto, decimal valorTaxa, decimal desconto, int quantidadeEsperada, int quantidadeRecebida)
//        {
//            OCFornecedor = oCFornecedor;
//            Moeda = moeda;
//            Produto = produto;
//            ProdutoAtributo = produtoAtributo;
//            Nome = nome;
//            Referencia = referencia;
//            ReferenciaFornecedor = referenciaFornecedor;
//            EAN13 = eAN13;
//            UPC = uPC;
//            TaxaTroca = taxaTroca;
//            PrecoUnitario = precoUnitario;
//            Preco = preco;
//            PrecoComDesconto = precoComDesconto;
//            TaxaImposto = taxaImposto;
//            ValorTaxa = valorTaxa;
//            Desconto = desconto;
//            QuantidadeEsperada = quantidadeEsperada;
//            QuantidadeRecebida = quantidadeRecebida;
//        }

//        public OCFornecedor OCFornecedor { get;  set; }
//        public Financeiro.Moeda Moeda { get;  set; }
//        public Produto.Produto Produto { get;  set; }
//        public Produto.ProdutoAtributo ProdutoAtributo { get;  set; }
//        public String Nome { get;  set; }
//        public String Referencia { get;  set; }
//        public String ReferenciaFornecedor { get;  set; }
//        public String EAN13 { get;  set; }
//        public String UPC { get;  set; }
//        public Decimal TaxaTroca { get;  set; }
//        public Decimal PrecoUnitario { get;  set; }
//        public Decimal Preco { get;  set; }
//        public Decimal PrecoComDesconto { get;  set; }
//        public Decimal TaxaImposto { get;  set; }
//        public Decimal ValorTaxa { get;  set; }
//        public Decimal Desconto { get;  set; }
//        public int QuantidadeEsperada { get;  set; }
//        public int QuantidadeRecebida { get;  set; }
//    }
//}
