//using System;
//using System.Collections.Generic;
//using System.Text;
//using SCommerce.Domain.Entities.CadastroBase;
//using SCommerce.Domain.Entities.Cliente;

//namespace SCommerce.Domain.Entities.Financeiro
//{
//    public class CarrinhoRegra : Base
//    {
//        public CarrinhoRegra(Guid ID)
//            : base(ID)
//        {

//        }

//        public CarrinhoRegra(ICollection<Cliente.Cliente> cliente, ICollection<Loja> lojas, ICollection<Pais> pais, ICollection<Provincia> provincia, string nome, DateTime dataDe, DateTime dataPara, string descricao, int quantidade, int quantidadePorUsuario, int prioridade, bool usoParcial, string codigo, decimal quantidadeMinima, bool restricaPais, bool restricaEnvio, bool grupoRestricao, bool restricaoRegraCarrinho, bool produtoRestricao, bool restricaLoja, bool envioGratis, decimal percentualDesconto, decimal descontoPorQuantidade, decimal descontoImposto, decimal descontoProduto, decimal descontoMoeda, decimal destaque, decimal ativo, DateTime cadastro, DateTime atualizado)
//        {
//            Cliente = cliente;
//            Lojas = lojas;
//            Pais = pais;
//            Provincia = provincia;
//            Nome = nome;
//            DataDe = dataDe;
//            DataPara = dataPara;
//            Descricao = descricao;
//            Quantidade = quantidade;
//            QuantidadePorUsuario = quantidadePorUsuario;
//            Prioridade = prioridade;
//            UsoParcial = usoParcial;
//            Codigo = codigo;
//            QuantidadeMinima = quantidadeMinima;
//            RestricaPais = restricaPais;
//            RestricaEnvio = restricaEnvio;
//            GrupoRestricao = grupoRestricao;
//            RestricaoRegraCarrinho = restricaoRegraCarrinho;
//            ProdutoRestricao = produtoRestricao;
//            RestricaLoja = restricaLoja;
//            EnvioGratis = envioGratis;
//            PercentualDesconto = percentualDesconto;
//            DescontoPorQuantidade = descontoPorQuantidade;
//            DescontoImposto = descontoImposto;
//            DescontoProduto = descontoProduto;
//            DescontoMoeda = descontoMoeda;
//            Destaque = destaque;
//            Ativo = ativo;
//            Cadastro = cadastro;
//            Atualizado = atualizado;
//        }

//        public ICollection<Cliente.Cliente> Cliente { get;  set; }
//        public ICollection<CadastroBase.Loja> Lojas { get;  set; }
//        public ICollection<CadastroBase.Pais> Pais { get;  set; }
//        public ICollection<CadastroBase.Provincia> Provincia { get;  set; }
//        //public ICollection<ProdutoRegra> ProdutoRegra { get;  set; }
//        //public ICollection<CarrinhoRegraGrupo> CarrinhoRegraGrupos { get;  set; }
//        //public ICollection<CarrinhoRegraCombinacao> CarrinhoRegraCombinacaos { get;  set; }
//        //public ICollection<CarrinhoRegraProdutoRegraGrupo> CarrinhoRegraProdutoRegraGrupos { get;  set; }
//        //public ICollection<CarrinhoRegraProdutoRegraValor> CarrinhoRegraProdutoRegraValor { get;  set; }
//        //public ICollection<CarrinhoRegraTransportadora> CarrinhoRegraTransportadora { get;  set; }
//        public String Nome { get;  set; }
//        public DateTime DataDe { get;  set; }
//        public DateTime DataPara { get;  set; }
//        public String Descricao { get;  set; }
//        public int Quantidade { get;  set; }
//        public int QuantidadePorUsuario { get;  set; }
//        public int Prioridade { get;  set; }
//        public Boolean UsoParcial { get;  set; }
//        public String Codigo { get;  set; }
//        public Decimal QuantidadeMinima { get;  set; }
//        public Boolean RestricaPais { get;  set; }
//        public Boolean RestricaEnvio { get;  set; }
//        public Boolean GrupoRestricao { get;  set; }
//        public Boolean RestricaoRegraCarrinho { get;  set; }
//        public Boolean ProdutoRestricao { get;  set; }
//        public Boolean RestricaLoja { get;  set; }
//        public Boolean EnvioGratis { get;  set; }
//        public Decimal PercentualDesconto { get;  set; }
//        public Decimal DescontoPorQuantidade { get;  set; }
//        public Decimal DescontoImposto { get;  set; }
//        public Decimal DescontoProduto { get;  set; }
//        public Decimal DescontoMoeda { get;  set; }
//        public Decimal Destaque { get;  set; }
//        public Decimal Ativo { get;  set; }
//        public DateTime Cadastro { get;  set; }
//        public DateTime Atualizado { get;  set; }
//    }
//}
