using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SCommerce.Infra.Data.EF;
using AutoMapper;
using SCommerce.Domain.Entities;
using SCommerce.Infra.Data.Repositories;

namespace bCommerce.b2SalesFashion
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            services.AddSession();
            services.AddAutoMapper();
            services.AddScoped<ScContext, ScContext>();



            #region Aplication
            //services.AddTransient<Application.Interfaces.CadastroBase.IAnexoAppService, Application.Services.CadastroBase.AnexoAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IArquivoMensagemAppService, Application.Services.CadastroBase.ArquivoMensagemAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IAtributoLojaAppService, Application.Services.CadastroBase.AtributoLojaAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.ICidadeAppService, Application.Services.CadastroBase.CidadeAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IContatoEmailAppService, Application.Services.CadastroBase.ContatoEmailAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IContatoLojaAppService, Application.Services.CadastroBase.ContatoLojaAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IContatoRedeSocialAppService, Application.Services.CadastroBase.ContatoRedeSocialAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IContatoTelefoneAppService, Application.Services.CadastroBase.ContatoTelefoneAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IDepartamentoAppService, Application.Services.CadastroBase.DepartamentoAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IEnderecoAppService, Application.Services.CadastroBase.EnderecoAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IGrupoAppService, Application.Services.CadastroBase.GrupoAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.ILojaAppService, Application.Services.CadastroBase.LojaAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.ILojaDepartamentoAppService, Application.Services.CadastroBase.LojaDepartamentoAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.ILojaGrupoAppService, Application.Services.CadastroBase.LojaGrupoAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.ILojaImagensAppService, Application.Services.CadastroBase.LojaImagensAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IPaisAppService, Application.Services.CadastroBase.PaisAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IProvinciaAppService, Application.Services.CadastroBase.ProvinciaAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IRegiaoAppService, Application.Services.CadastroBase.RegiaoAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.ISistemaOperacionalAppService, Application.Services.CadastroBase.SistemaOperacionalAppService>();
            //services.AddTransient<Application.Interfaces.CadastroBase.IWebBrownserAppService, Application.Services.CadastroBase.WebBrownserAppService>();
            //services.AddTransient<Application.Interfaces.Carrinho.ICarrinhoAppService, Application.Services.Carrinho.CarrinhoAppService>();
            //services.AddTransient<Application.Interfaces.Carrinho.ICarrinhoProdutoAppService, Application.Services.Carrinho.CarrinhoProdutoAppService>();
            //services.AddTransient<Application.Interfaces.Cliente.ICategoriaGrupoAppService, Application.Services.Cliente.CategoriaGrupoAppService>();
            //services.AddTransient<Application.Interfaces.Cliente.IClienteAppService, Application.Services.Cliente.ClienteAppService>();
            //services.AddTransient<Application.Interfaces.Cliente.IClienteGrupoAppService, Application.Services.Cliente.ClienteGrupoAppService>();
            //services.AddTransient<Application.Interfaces.Cliente.IClienteMensagemAppService, Application.Services.Cliente.ClienteMensagemAppService>();
            //services.AddTransient<Application.Interfaces.Cliente.IClienteProcessoAppService, Application.Services.Cliente.ClienteProcessoAppService>();
            //services.AddTransient<Application.Interfaces.Cliente.IContatoAppService, Application.Services.Cliente.ContatoAppService>();
            //services.AddTransient<Application.Interfaces.Cliente.IGeneroAppService, Application.Services.Cliente.GeneroAppService>();
            //services.AddTransient<Application.Interfaces.Cliente.IGrupoAppService, Application.Services.Cliente.GrupoAppService>();
            //services.AddTransient<Application.Interfaces.Cliente.IGrupoDescontoAppService, Application.Services.Cliente.GrupoDescontoAppService>();
            //services.AddTransient<Application.Interfaces.Cliente.IRiscoAppService, Application.Services.Cliente.RiscoAppService>();
            //services.AddTransient<Application.Interfaces.Cliente.IVisitanteAppService, Application.Services.Cliente.VisitanteAppService>();
            //services.AddTransient<Application.Interfaces.CMS.ICMSAppService, Application.Services.CMS.CMSAppService>();
            //services.AddTransient<Application.Interfaces.CMS.ICMSCategoriaAppService, Application.Services.CMS.CMSCategoriaAppService>();
            //services.AddTransient<Application.Interfaces.CMS.ICMSLojaAppService, Application.Services.CMS.CMSLojaAppService>();
            //services.AddTransient<Application.Interfaces.Deposito.IDepositoAppService, Application.Services.Deposito.DepositoAppService>();
            //services.AddTransient<Application.Interfaces.Deposito.IDepositoLojaAppService, Application.Services.Deposito.DepositoLojaAppService>();
            //services.AddTransient<Application.Interfaces.Deposito.IDepositoProdutoLocalizacaoAppService, Application.Services.Deposito.DepositoProdutoLocalizacaoAppService>();
            //services.AddTransient<Application.Interfaces.Deposito.IDepositoTransportadoraAppService, Application.Services.Deposito.DepositoTransportadoraAppService>();
            //services.AddTransient<Application.Interfaces.Empregado.IAcessoAppService, Application.Services.Empregado.AcessoAppService>();
            //services.AddTransient<Application.Interfaces.Empregado.IEmpregadoAppService, Application.Services.Empregado.EmpregadoAppService>();
            //services.AddTransient<Application.Interfaces.Empregado.IEmpregadoLojaAppService, Application.Services.Empregado.EmpregadoLojaAppService>();
            //services.AddTransient<Application.Interfaces.Empregado.IMensagemAppService, Application.Services.Empregado.MensagemAppService>();
            //services.AddTransient<Application.Interfaces.Empregado.IModuloAppService, Application.Services.Empregado.ModuloAppService>();
            //services.AddTransient<Application.Interfaces.Empregado.IPerfilAppService, Application.Services.Empregado.PerfilAppService>();
            //services.AddTransient<Application.Interfaces.Estoque.IEstoqueAppService, Application.Services.Estoque.EstoqueAppService>();
            //services.AddTransient<Application.Interfaces.Estoque.IEstoqueMovimentoAppService, Application.Services.Estoque.EstoqueMovimentoAppService>();
            //services.AddTransient<Application.Interfaces.Estoque.IEstoqueMovimentoRazaoAppService, Application.Services.Estoque.EstoqueMovimentoRazaoAppService>();
            //services.AddTransient<Application.Interfaces.Fabricante.IFabricanteAppService, Application.Services.Fabricante.FabricanteAppService>();
            //services.AddTransient<Application.Interfaces.Fabricante.IFabricanteFornecedorAppService, Application.Services.Fabricante.FabricanteFornecedorAppService>();
            //services.AddTransient<Application.Interfaces.Fabricante.IFabricanteLojaAppService, Application.Services.Fabricante.FabricanteLojaAppService>();
            //services.AddTransient<Application.Interfaces.Financeiro.ICarrinhoAppService, Application.Services.Financeiro.CarrinhoAppService>();
            //services.AddTransient<Application.Interfaces.Financeiro.IMetodoPagamentoAppService, Application.Services.Financeiro.MetodoPagamentoAppService>();
            //services.AddTransient<Application.Interfaces.Financeiro.IMoedaAppService, Application.Services.Financeiro.MoedaAppService>();
            //services.AddTransient<Application.Interfaces.Financeiro.IMoedaLojaAppService, Application.Services.Financeiro.MoedaLojaAppService>();
            //services.AddTransient<Application.Interfaces.Financeiro.IPrecoEspecificoAppService, Application.Services.Financeiro.PrecoEspecificoAppService>();
            //services.AddTransient<Application.Interfaces.Financeiro.IPrecoEspecificoPrioridadeAppService, Application.Services.Financeiro.PrecoEspecificoPrioridadeAppService>();
            //services.AddTransient<Application.Interfaces.Financeiro.IPrecoEspecificoRegraAppService, Application.Services.Financeiro.PrecoEspecificoRegraAppService>();
            //services.AddTransient<Application.Interfaces.Fornecedor.IFornecedorAppService, Application.Services.Fornecedor.FornecedorAppService>();
            //services.AddTransient<Application.Interfaces.Fornecedor.IFornecedorLojaAppService, Application.Services.Fornecedor.FornecedorLojaAppService>();
            //services.AddTransient<Application.Interfaces.OC.ICustomizacaoAppService, Application.Services.OC.CustomizacaoAppService>();
            //services.AddTransient<Application.Interfaces.OC.ICustomizacaoDadosAppService, Application.Services.OC.CustomizacaoDadosAppService>();
            //services.AddTransient<Application.Interfaces.OC.IDetalhePedidoAppService, Application.Services.OC.DetalhePedidoAppService>();
            //services.AddTransient<Application.Interfaces.OC.IOCAppService, Application.Services.OC.OCAppService>();
            //services.AddTransient<Application.Interfaces.OC.IOCAppStatusService, Application.Services.OC.OCStatusAppService>();
            //services.AddTransient<Application.Interfaces.OC.IOCDetalhesAppService, Application.Services.OC.OCDetalhesAppService>();
            //services.AddTransient<Application.Interfaces.OC.IOCFaturaAppService, Application.Services.OC.OCFaturaAppService>();
            //services.AddTransient<Application.Interfaces.OC.IOCFaturaPagamentoAppService, Application.Services.OC.OCFaturaPagamentoAppService>();
            //services.AddTransient<Application.Interfaces.OC.IOCHistoricoAppService, Application.Services.OC.OCHistoricoAppService>();
            //services.AddTransient<Application.Interfaces.OC.IOCMensagemAppService, Application.Services.OC.OCMensagemAppService>();
            //services.AddTransient<Application.Interfaces.OC.IOCPagamentoAppService, Application.Services.OC.OCPagamentoAppService>();
            //services.AddTransient<Application.Interfaces.OC.IOCPedidoAppService, Application.Services.OC.OCPedidoAppService>();
            //services.AddTransient<Application.Interfaces.OC.IOCRetornoAppService, Application.Services.OC.OCRetornoAppService>();
            //services.AddTransient<Application.Interfaces.OC.IOCRetornoDetalhesAppService, Application.Services.OC.OCRetornoDetalhesAppService>();
            //services.AddTransient<Application.Interfaces.OC.IOCRetornoStatusAppService, Application.Services.OC.OCRetornoStatusAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IAcessorioAppService, Application.Services.Produto.AcessorioAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IAtributoAppService, Application.Services.Produto.AtributoAppService>();
            //services.AddTransient<Application.Interfaces.Produto.ICampoCustomizavelAppService, Application.Services.Produto.CampoCustomizavelAppService>();
            //services.AddTransient<Application.Interfaces.Produto.ICategoriaAppService, Application.Services.Produto.CategoriaAppService>();
            //services.AddTransient<Application.Interfaces.Produto.ICategoriaLojaAppService, Application.Services.Produto.CategoriaLojaAppService>();
            //services.AddTransient<Application.Interfaces.Produto.ICategoriaProdutoAppService, Application.Services.Produto.CategoriaProdutoAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IIndexPesquisaAppService, Application.Services.Produto.IndexPesquisaAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoAnexoAppService, Application.Services.Produto.ProdutoAnexoAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoAppService, Application.Services.Produto.ProdutoAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoAtributoAppService, Application.Services.Produto.ProdutoAtributoAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoAtributoCombinacaoAppService, Application.Services.Produto.ProdutoAtributoCombinacaoAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoAtributoImagemAppService, Application.Services.Produto.ProdutoAtributoImagemAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoAtributoLojaAppService, Application.Services.Produto.ProdutoAtributoLojaAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoFornecedorAppService, Application.Services.Produto.ProdutoFornecedorAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoGrupoAppService, Application.Services.Produto.ProdutoGrupoAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoImagemAppService, Application.Services.Produto.ProdutoImagemAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoLojaAppService, Application.Services.Produto.ProdutoLojaAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoPropriedadeAppService, Application.Services.Produto.ProdutoPropriedadeAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoTagAppService, Application.Services.Produto.ProdutoTagAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoTransportadoraAppService, Application.Services.Produto.ProdutoTransportadoraAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IProdutoVendaAppService, Application.Services.Produto.ProdutoVendaAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IPropriedadeAppService, Application.Services.Produto.PropriedadeAppService>();
            //services.AddTransient<Application.Interfaces.Produto.IPropriedadeValorAppService, Application.Services.Produto.PropriedadeValorAppService>();
            //services.AddTransient<Application.Interfaces.Produto.ITagAppService, Application.Services.Produto.TagAppService>();
            //services.AddTransient<Application.Interfaces.Transportadora.IEntregaAppService, Application.Services.Transportadora.EntregaAppService>();
            //services.AddTransient<Application.Interfaces.Transportadora.IFaixaDePesoAppService, Application.Services.Transportadora.FaixaDePesoAppService>();
            //services.AddTransient<Application.Interfaces.Transportadora.IFaixaDePrecoAppService, Application.Services.Transportadora.FaixaDePrecoAppService>();
            //services.AddTransient<Application.Interfaces.Transportadora.ITransportadoraAppService, Application.Services.Transportadora.TransportadoraAppService>();
            //services.AddTransient<Application.Interfaces.Transportadora.ITransportadoraGrupoAppService, Application.Services.Transportadora.TransportadoraGrupoAppService>();
            //services.AddTransient<Application.Interfaces.Transportadora.ITransportadoraLojaAppService, Application.Services.Transportadora.TransportadoraLojaAppService>();
            //services.AddTransient<Application.Interfaces.Transportadora.ITransportadoraRegiaoAppService, Application.Services.Transportadora.TransportadoraRegiaoAppService>();
            #endregion


            #region Repositories
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.IAnexoRepository, SCommerce.Infra.Data.Repositories.CadastroBase.AnexoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.ICidadeRepository, SCommerce.Infra.Data.Repositories.CadastroBase.CidadeRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.IContatoEmailRepository, SCommerce.Infra.Data.Repositories.CadastroBase.ContatoEmailRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.IContatoLojaRepository, SCommerce.Infra.Data.Repositories.CadastroBase.ContatoLojaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.IContatoRedeSocialRepository, SCommerce.Infra.Data.Repositories.CadastroBase.ContatoRedeSocialRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.IContatoTelefoneRepository, SCommerce.Infra.Data.Repositories.CadastroBase.ContatoTelefoneRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.IDepartamentoRepository, SCommerce.Infra.Data.Repositories.CadastroBase.DepartamentoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.IEnderecoRepository, SCommerce.Infra.Data.Repositories.CadastroBase.EnderecoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.IGrupoRepository, SCommerce.Infra.Data.Repositories.CadastroBase.GrupoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.ILojaDepartamentoRepository, SCommerce.Infra.Data.Repositories.CadastroBase.LojaDepartamentoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.ILojaImagensRepository, SCommerce.Infra.Data.Repositories.CadastroBase.LojaImagensRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.ILojaRepository, SCommerce.Infra.Data.Repositories.CadastroBase.LojaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.IPaisRepository, SCommerce.Infra.Data.Repositories.CadastroBase.PaisRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.IProvinciaRepository, SCommerce.Infra.Data.Repositories.CadastroBase.ProvinciaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.IRegiaoRepository, SCommerce.Infra.Data.Repositories.CadastroBase.RegiaoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.ISistemaOperacionalRepository, SCommerce.Infra.Data.Repositories.CadastroBase.SistemaOperacionalRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CadastroBase.IWebBrownserRepository, SCommerce.Infra.Data.Repositories.CadastroBase.WebBrownserRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Carrinho.ICarrinhoProdutoRepository, SCommerce.Infra.Data.Repositories.Carrinho.CarrinhoProdutoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Carrinho.ICarrinhoRepository, SCommerce.Infra.Data.Repositories.Carrinho.CarrinhoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Cliente.IClienteMensagemRepository, SCommerce.Infra.Data.Repositories.Cliente.ClienteMensagemRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Cliente.IClienteProcessoRepository, SCommerce.Infra.Data.Repositories.Cliente.ClienteProcessoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Cliente.IClienteRepository, SCommerce.Infra.Data.Repositories.Cliente.ClienteRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Cliente.IContatoRepository, SCommerce.Infra.Data.Repositories.Cliente.ContatoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CMS.ICMSCategoriaRepository, SCommerce.Infra.Data.Repositories.CMS.CMSCategoriaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CMS.ICMSLojaRepository, SCommerce.Infra.Data.Repositories.CMS.CMSLojaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.CMS.ICMSRepository, SCommerce.Infra.Data.Repositories.CMS.CMSRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Empregado.IAcessoRepository, SCommerce.Infra.Data.Repositories.Empregado.AcessoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Empregado.IEmpregadoLojaRepository, SCommerce.Infra.Data.Repositories.Empregado.EmpregadoLojaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Empregado.IEmpregadoRepository, SCommerce.Infra.Data.Repositories.Empregado.EmpregadoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Empregado.IModuloRepository, SCommerce.Infra.Data.Repositories.Empregado.ModuloRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Empregado.IPerfilRepository, SCommerce.Infra.Data.Repositories.Empregado.PerfilRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Fabricante.IFabricanteFornecedorRepository, SCommerce.Infra.Data.Repositories.Fabricante.FabricanteFornecedorRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Fabricante.IFabricanteLojaRepository, SCommerce.Infra.Data.Repositories.Fabricante.FabricanteLojaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Fabricante.IFabricanteRepository, SCommerce.Infra.Data.Repositories.Fabricante.FabricanteRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Financeiro.IMetodoPagamentoRepository, SCommerce.Infra.Data.Repositories.Financeiro.MetodoPagamentoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Financeiro.IMoedaRepository, SCommerce.Infra.Data.Repositories.Financeiro.MoedaRepository>();
           
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Fornecedor.IFornecedorLojaRepository, SCommerce.Infra.Data.Repositories.Fornecedor.FornecedorLojaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Fornecedor.IFornecedorRepository, SCommerce.Infra.Data.Repositories.Fornecedor.FornecedorRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.OC.IOCDetalhesRepository, SCommerce.Infra.Data.Repositories.OC.OCDetalhesRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.OC.IOCFaturaRepository, SCommerce.Infra.Data.Repositories.OC.OCFaturaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.OC.IOCMensagemRepository, SCommerce.Infra.Data.Repositories.OC.OCMensagemRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.OC.IOCPagamentoRepository, SCommerce.Infra.Data.Repositories.OC.OCPagamentoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.OC.IOCRepository, SCommerce.Infra.Data.Repositories.OC.OCRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.OC.IOCRetornoStatusRepository, SCommerce.Infra.Data.Repositories.OC.OCRetornoStatusRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.OC.IOCStatusRepository, SCommerce.Infra.Data.Repositories.OC.OCStatusRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.IAtributoRepository, SCommerce.Infra.Data.Repositories.Produto.AtributoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.ICategoriaLojaRepository, SCommerce.Infra.Data.Repositories.Produto.CategoriaLojaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.ICategoriaProdutoRepository, SCommerce.Infra.Data.Repositories.Produto.CategoriaProdutoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.ICategoriaRepository, SCommerce.Infra.Data.Repositories.Produto.CategoriaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.IIndexPesquisaRepository, SCommerce.Infra.Data.Repositories.Produto.IndexPesquisaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.IProdutoFornecedorRepository, SCommerce.Infra.Data.Repositories.Produto.ProdutoFornecedorRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.IProdutoGrupoRepository, SCommerce.Infra.Data.Repositories.Produto.ProdutoGrupoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.IProdutoImagemRepository, SCommerce.Infra.Data.Repositories.Produto.ProdutoImagemRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.IProdutoLojaRepository, SCommerce.Infra.Data.Repositories.Produto.ProdutoLojaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.IProdutoPropriedadeRepository, SCommerce.Infra.Data.Repositories.Produto.ProdutoPropriedadeRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.IProdutoRepository, SCommerce.Infra.Data.Repositories.Produto.ProdutoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.IProdutoTagRepository, SCommerce.Infra.Data.Repositories.Produto.ProdutoTagRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.IProdutoTransportadoraRepository, SCommerce.Infra.Data.Repositories.Produto.ProdutoTransportadoraRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.IPropriedadeRepository, SCommerce.Infra.Data.Repositories.Produto.PropriedadeRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.IPropriedadeValorRepository, SCommerce.Infra.Data.Repositories.Produto.PropriedadeValorRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Produto.ITagRepository, SCommerce.Infra.Data.Repositories.Produto.TagAppRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Transportadora.IEntregaRepository, SCommerce.Infra.Data.Repositories.Transportadora.EntregaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Transportadora.IFaixaDePesoRepository, SCommerce.Infra.Data.Repositories.Transportadora.FaixaDePesoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Transportadora.IFaixaDePrecoRepository, SCommerce.Infra.Data.Repositories.Transportadora.FaixaDePrecoRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Transportadora.ITransportadoraLojaRepository, SCommerce.Infra.Data.Repositories.Transportadora.TransportadoraLojaRepository>();
            services.AddTransient<SCommerce.Domain.Interfaces.Repositories.Transportadora.ITransportadoraRepository, SCommerce.Infra.Data.Repositories.Transportadora.TransportadoraRepository>();
            #endregion


            #region Services
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.IAnexoService, SCommerce.Domain.Services.CadastroBase.AnexoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.ICidadeService, SCommerce.Domain.Services.CadastroBase.CidadeService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.IContatoEmailService, SCommerce.Domain.Services.CadastroBase.ContatoEmailService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.IContatoLojaService, SCommerce.Domain.Services.CadastroBase.ContatoLojaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.IContatoRedeSocialService, SCommerce.Domain.Services.CadastroBase.ContatoRedeSocialService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.IContatoTelefoneService, SCommerce.Domain.Services.CadastroBase.ContatoTelefoneService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.IDepartamentoService, SCommerce.Domain.Services.CadastroBase.DepartamentoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.IEnderecoService, SCommerce.Domain.Services.CadastroBase.EnderecoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.IGrupoService, SCommerce.Domain.Services.CadastroBase.GrupoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.ILojaDepartamentoService, SCommerce.Domain.Services.CadastroBase.LojaDepartamentoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.ILojaImagensService, SCommerce.Domain.Services.CadastroBase.LojaImagensService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.ILojaService, SCommerce.Domain.Services.CadastroBase.LojaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.IPaisService, SCommerce.Domain.Services.CadastroBase.PaisService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.IProvinciaService, SCommerce.Domain.Services.CadastroBase.ProvinciaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.IRegiaoService, SCommerce.Domain.Services.CadastroBase.RegiaoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.ISistemaOperacionalService, SCommerce.Domain.Services.CadastroBase.SistemaOperacionalService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CadastroBase.IWebBrownserService, SCommerce.Domain.Services.CadastroBase.WebBrownserService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Carrinho.ICarrinhoProdutoService, SCommerce.Domain.Services.Carrinho.CarrinhoProdutoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Carrinho.ICarrinhoService, SCommerce.Domain.Services.Carrinho.CarrinhoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Cliente.IClienteMensagemService, SCommerce.Domain.Services.Cliente.ClienteMensagemService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Cliente.IClienteProcessoService, SCommerce.Domain.Services.Cliente.ClienteProcessoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Cliente.IClienteService, SCommerce.Domain.Services.Cliente.ClienteService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Cliente.IContatoService, SCommerce.Domain.Services.Cliente.ContatoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CMS.ICMSCategoriaService, SCommerce.Domain.Services.CMS.CMSCategoriaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CMS.ICMSLojaService, SCommerce.Domain.Services.CMS.CMSLojaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.CMS.ICMSService, SCommerce.Domain.Services.CMS.CMSService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Empregado.IAcessoService, SCommerce.Domain.Services.Empregado.AcessoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Empregado.IEmpregadoLojaService, SCommerce.Domain.Services.Empregado.EmpregadoLojaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Empregado.IEmpregadoService, SCommerce.Domain.Services.Empregado.EmpregadoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Empregado.IModuloService, SCommerce.Domain.Services.Empregado.ModuloService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Empregado.IPerfilService, SCommerce.Domain.Services.Empregado.PerfilService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Fabricante.IFabricanteFornecedorService, SCommerce.Domain.Services.Fabricante.FabricanteFornecedorService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Fabricante.IFabricanteLojaService, SCommerce.Domain.Services.Fabricante.FabricanteLojaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Fabricante.IFabricanteService, SCommerce.Domain.Services.Fabricante.FabricanteService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Financeiro.IMetodoPagamentoService, SCommerce.Domain.Services.Financeiro.MetodoPagamentoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Financeiro.IMoedaService, SCommerce.Domain.Services.Financeiro.MoedaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Fornecedor.IFornecedorLojaService, SCommerce.Domain.Services.Fornecedor.FornecedorLojaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Fornecedor.IFornecedorLojaService, SCommerce.Domain.Services.Fornecedor.FornecedorLojaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.OC.IOCDetalhesService, SCommerce.Domain.Services.OC.OCDetalhesService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.OC.IOCFaturaService, SCommerce.Domain.Services.OC.OCFaturaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.OC.IOCMensagemService, SCommerce.Domain.Services.OC.OCMensagemService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.OC.IOCPagamentoService, SCommerce.Domain.Services.OC.OCPagamentoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.OC.IOCRetornoStatusService, SCommerce.Domain.Services.OC.OCRetornoStatusService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.OC.IOCService, SCommerce.Domain.Services.OC.OCService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.OC.IOCStatusAppService, SCommerce.Domain.Services.OC.OCStatusService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.IAtributoService, SCommerce.Domain.Services.Produto.AtributoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.ICategoriaLojaService, SCommerce.Domain.Services.Produto.CategoriaLojaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.ICategoriaProdutoService, SCommerce.Domain.Services.Produto.CategoriaProdutoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.ICategoriaService, SCommerce.Domain.Services.Produto.CategoriaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.IIndexPesquisaService, SCommerce.Domain.Services.Produto.IndexPesquisaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.IProdutoFornecedorService, SCommerce.Domain.Services.Produto.ProdutoFornecedorService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.IProdutoGrupoService, SCommerce.Domain.Services.Produto.ProdutoGrupoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.IProdutoImagemService, SCommerce.Domain.Services.Produto.ProdutoImagemService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.IProdutoLojaService, SCommerce.Domain.Services.Produto.ProdutoLojaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.IProdutoPropriedadeService, SCommerce.Domain.Services.Produto.ProdutoPropriedadeService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.IProdutoService, SCommerce.Domain.Services.Produto.ProdutoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.IProdutoTagService, SCommerce.Domain.Services.Produto.ProdutoTagService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.IProdutoTransportadoraService, SCommerce.Domain.Services.Produto.ProdutoTransportadoraService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.IPropriedadeService, SCommerce.Domain.Services.Produto.PropriedadeService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.IPropriedadeValorService, SCommerce.Domain.Services.Produto.PropriedadeValorService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Produto.ITagService, SCommerce.Domain.Services.Produto.TagService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Transportadora.IEntregaService, SCommerce.Domain.Services.Transportadora.EntregaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Transportadora.IFaixaDePesoService, SCommerce.Domain.Services.Transportadora.FaixaDePesoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Transportadora.IFaixaDePrecoService, SCommerce.Domain.Services.Transportadora.FaixaDePrecoService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Transportadora.ITransportadoraLojaService, SCommerce.Domain.Services.Transportadora.TransportadoraLojaService>();
            services.AddTransient<SCommerce.Domain.Interfaces.Services.Transportadora.ITransportadoraService, SCommerce.Domain.Services.Transportadora.TransportadoraService>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
