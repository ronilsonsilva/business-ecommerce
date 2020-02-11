using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SCommerce.Web.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using SCommerce.Infra.Data.EF;

namespace SCommerce.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddAutoMapper();
            services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            services.AddSession();
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
            ////services.AddTransient<Application.Interfaces.Cliente.IClienteGrupoAppService, Application.Services.Cliente.ClienteGrupoAppService>();
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
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IAnexoRepository, Infra.Data.Repositories.CadastroBase.AnexoRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.ICidadeRepository, Infra.Data.Repositories.CadastroBase.CidadeRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IContatoEmailRepository, Infra.Data.Repositories.CadastroBase.ContatoEmailRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IContatoLojaRepository, Infra.Data.Repositories.CadastroBase.ContatoLojaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IContatoRedeSocialRepository, Infra.Data.Repositories.CadastroBase.ContatoRedeSocialRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IContatoTelefoneRepository, Infra.Data.Repositories.CadastroBase.ContatoTelefoneRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IDepartamentoRepository, Infra.Data.Repositories.CadastroBase.DepartamentoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IEnderecoRepository, Infra.Data.Repositories.CadastroBase.EnderecoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IGrupoRepository, Infra.Data.Repositories.CadastroBase.GrupoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.ILojaDepartamentoRepository, Infra.Data.Repositories.CadastroBase.LojaDepartamentoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.ILojaImagensRepository, Infra.Data.Repositories.CadastroBase.LojaImagensRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.ILojaRepository, Infra.Data.Repositories.CadastroBase.LojaRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IPaisRepository, Infra.Data.Repositories.CadastroBase.PaisRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IProvinciaRepository, Infra.Data.Repositories.CadastroBase.ProvinciaRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IRegiaoRepository, Infra.Data.Repositories.CadastroBase.RegiaoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.ISistemaOperacionalRepository, Infra.Data.Repositories.CadastroBase.SistemaOperacionalRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IWebBrownserRepository, Infra.Data.Repositories.CadastroBase.WebBrownserRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Carrinho.ICarrinhoProdutoRepository, Infra.Data.Repositories.Carrinho.CarrinhoProdutoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Carrinho.ICarrinhoRepository, Infra.Data.Repositories.Carrinho.CarrinhoRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.Cliente.IClienteMensagemRepository, Infra.Data.Repositories.Cliente.ClienteMensagemRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Cliente.IClienteProcessoRepository, Infra.Data.Repositories.Cliente.ClienteProcessoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Cliente.IClienteRepository, Infra.Data.Repositories.Cliente.ClienteRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Cliente.IContatoRepository, Infra.Data.Repositories.Cliente.ContatoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CMS.ICMSCategoriaRepository, Infra.Data.Repositories.CMS.CMSCategoriaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CMS.ICMSLojaRepository, Infra.Data.Repositories.CMS.CMSLojaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CMS.ICMSRepository, Infra.Data.Repositories.CMS.CMSRepository> ();
            
            services.AddTransient<Domain.Interfaces.Repositories.Empregado.IAcessoRepository, Infra.Data.Repositories.Empregado.AcessoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Empregado.IEmpregadoLojaRepository, Infra.Data.Repositories.Empregado.EmpregadoLojaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Empregado.IEmpregadoRepository, Infra.Data.Repositories.Empregado.EmpregadoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Empregado.IModuloRepository, Infra.Data.Repositories.Empregado.ModuloRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Empregado.IPerfilRepository, Infra.Data.Repositories.Empregado.PerfilRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Fabricante.IFabricanteFornecedorRepository, Infra.Data.Repositories.Fabricante.FabricanteFornecedorRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Fabricante.IFabricanteLojaRepository, Infra.Data.Repositories.Fabricante.FabricanteLojaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Fabricante.IFabricanteRepository, Infra.Data.Repositories.Fabricante.FabricanteRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Financeiro.IMetodoPagamentoRepository, Infra.Data.Repositories.Financeiro.MetodoPagamentoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Financeiro.IMoedaRepository, Infra.Data.Repositories.Financeiro.MoedaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Fornecedor.IFornecedorLojaRepository, Infra.Data.Repositories.Fornecedor.FornecedorLojaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Fornecedor.IFornecedorRepository, Infra.Data.Repositories.Fornecedor.FornecedorRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.OC.IOCDetalhesRepository, Infra.Data.Repositories.OC.OCDetalhesRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.OC.IOCFaturaRepository, Infra.Data.Repositories.OC.OCFaturaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.OC.IOCMensagemRepository, Infra.Data.Repositories.OC.OCMensagemRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.OC.IOCPagamentoRepository, Infra.Data.Repositories.OC.OCPagamentoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.OC.IOCRepository, Infra.Data.Repositories.OC.OCRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.OC.IOCRetornoStatusRepository, Infra.Data.Repositories.OC.OCRetornoStatusRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.OC.IOCStatusRepository, Infra.Data.Repositories.OC.OCStatusRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.IAtributoRepository, Infra.Data.Repositories.Produto.AtributoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.ICategoriaLojaRepository, Infra.Data.Repositories.Produto.CategoriaLojaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.ICategoriaProdutoRepository, Infra.Data.Repositories.Produto.CategoriaProdutoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.ICategoriaRepository, Infra.Data.Repositories.Produto.CategoriaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.IIndexPesquisaRepository, Infra.Data.Repositories.Produto.IndexPesquisaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.IProdutoFornecedorRepository, Infra.Data.Repositories.Produto.ProdutoFornecedorRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.IProdutoGrupoRepository, Infra.Data.Repositories.Produto.ProdutoGrupoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.IProdutoImagemRepository, Infra.Data.Repositories.Produto.ProdutoImagemRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.IProdutoLojaRepository, Infra.Data.Repositories.Produto.ProdutoLojaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.IProdutoPropriedadeRepository, Infra.Data.Repositories.Produto.ProdutoPropriedadeRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.IProdutoRepository, Infra.Data.Repositories.Produto.ProdutoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.IProdutoTagRepository, Infra.Data.Repositories.Produto.ProdutoTagRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.IProdutoTransportadoraRepository, Infra.Data.Repositories.Produto.ProdutoTransportadoraRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.IPropriedadeRepository, Infra.Data.Repositories.Produto.PropriedadeRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.IPropriedadeValorRepository, Infra.Data.Repositories.Produto.PropriedadeValorRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Produto.ITagRepository, Infra.Data.Repositories.Produto.TagAppRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Transportadora.IEntregaRepository, Infra.Data.Repositories.Transportadora.EntregaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Transportadora.IFaixaDePesoRepository, Infra.Data.Repositories.Transportadora.FaixaDePesoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Transportadora.IFaixaDePrecoRepository, Infra.Data.Repositories.Transportadora.FaixaDePrecoRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Transportadora.ITransportadoraLojaRepository, Infra.Data.Repositories.Transportadora.TransportadoraLojaRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.Transportadora.ITransportadoraRepository, Infra.Data.Repositories.Transportadora.TransportadoraRepository> ();
            services.AddTransient<Domain.Interfaces.Repositories.CMS.ICMSEnderecoLojaRepository, Infra.Data.Repositories.CMS.CMSEnderecoLojaRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.CMS.ICMSLojaRepository, Infra.Data.Repositories.CMS.CMSLojaRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.CMS.ICMSRedeSocialRepository, Infra.Data.Repositories.CMS.CMSRedeSocialRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.CMS.ICMSSlidePrincipalRepository, Infra.Data.Repositories.CMS.CMSSlidePrincipalRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.CMS.ICMSWhatsAppRepository, Infra.Data.Repositories.CMS.CMSWhatsAppRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IContatoLojaEmailRepository, Infra.Data.Repositories.CadastroBase.ContatoLojaEmailRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IContatoLojaTelefoneRepository, Infra.Data.Repositories.CadastroBase.ContatoLojaTelefoneRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IContatoLojaEnderecoRepository, Infra.Data.Repositories.CadastroBase.ContatoLojaEnderecoRepository>();
            services.AddTransient<Domain.Interfaces.Repositories.CadastroBase.IContatoLojaRedeSocialRepository, Infra.Data.Repositories.CadastroBase.ContatoLojaRedeSocialRepository>();
            #endregion


            #region Services
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.IAnexoService, Domain.Services.CadastroBase.AnexoService>();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.ICidadeService, Domain.Services.CadastroBase.CidadeService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.IContatoEmailService, Domain.Services.CadastroBase.ContatoEmailService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.IContatoLojaService, Domain.Services.CadastroBase.ContatoLojaService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.IContatoRedeSocialService, Domain.Services.CadastroBase.ContatoRedeSocialService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.IContatoTelefoneService, Domain.Services.CadastroBase.ContatoTelefoneService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.IDepartamentoService, Domain.Services.CadastroBase.DepartamentoService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.IEnderecoService, Domain.Services.CadastroBase.EnderecoService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.IGrupoService, Domain.Services.CadastroBase.GrupoService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.ILojaDepartamentoService, Domain.Services.CadastroBase.LojaDepartamentoService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.ILojaImagensService, Domain.Services.CadastroBase.LojaImagensService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.ILojaService, Domain.Services.CadastroBase.LojaService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.IPaisService, Domain.Services.CadastroBase.PaisService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.IProvinciaService, Domain.Services.CadastroBase.ProvinciaService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.IRegiaoService, Domain.Services.CadastroBase.RegiaoService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.ISistemaOperacionalService, Domain.Services.CadastroBase.SistemaOperacionalService> ();
            services.AddTransient<Domain.Interfaces.Services.CadastroBase.IWebBrownserService, Domain.Services.CadastroBase.WebBrownserService> ();
            services.AddTransient<Domain.Interfaces.Services.Carrinho.ICarrinhoProdutoService, Domain.Services.Carrinho.CarrinhoProdutoService> ();
            services.AddTransient<Domain.Interfaces.Services.Carrinho.ICarrinhoService, Domain.Services.Carrinho.CarrinhoService> ();
            services.AddTransient<Domain.Interfaces.Services.Cliente.IClienteMensagemService, Domain.Services.Cliente.ClienteMensagemService> ();
            services.AddTransient<Domain.Interfaces.Services.Cliente.IClienteProcessoService, Domain.Services.Cliente.ClienteProcessoService> ();
            services.AddTransient<Domain.Interfaces.Services.Cliente.IClienteService, Domain.Services.Cliente.ClienteService> ();
            services.AddTransient<Domain.Interfaces.Services.Cliente.IContatoService, Domain.Services.Cliente.ContatoService> ();
            services.AddTransient<Domain.Interfaces.Services.CMS.ICMSCategoriaService, Domain.Services.CMS.CMSCategoriaService> ();
            services.AddTransient<Domain.Interfaces.Services.CMS.ICMSLojaService, Domain.Services.CMS.CMSLojaService> ();
            services.AddTransient<Domain.Interfaces.Services.CMS.ICMSService, Domain.Services.CMS.CMSService> ();
            services.AddTransient<Domain.Interfaces.Services.Empregado.IAcessoService, Domain.Services.Empregado.AcessoService> ();
            services.AddTransient<Domain.Interfaces.Services.Empregado.IEmpregadoLojaService, Domain.Services.Empregado.EmpregadoLojaService> ();
            services.AddTransient<Domain.Interfaces.Services.Empregado.IEmpregadoService, Domain.Services.Empregado.EmpregadoService> ();
            services.AddTransient<Domain.Interfaces.Services.Empregado.IModuloService, Domain.Services.Empregado.ModuloService> ();
            services.AddTransient<Domain.Interfaces.Services.Empregado.IPerfilService, Domain.Services.Empregado.PerfilService> ();
            services.AddTransient<Domain.Interfaces.Services.Fabricante.IFabricanteFornecedorService, Domain.Services.Fabricante.FabricanteFornecedorService> ();
            services.AddTransient<Domain.Interfaces.Services.Fabricante.IFabricanteLojaService, Domain.Services.Fabricante.FabricanteLojaService> ();
            services.AddTransient<Domain.Interfaces.Services.Fabricante.IFabricanteService, Domain.Services.Fabricante.FabricanteService> ();
            services.AddTransient<Domain.Interfaces.Services.Financeiro.IMetodoPagamentoService, Domain.Services.Financeiro.MetodoPagamentoService> ();
            services.AddTransient<Domain.Interfaces.Services.Financeiro.IMoedaService, Domain.Services.Financeiro.MoedaService> ();
            services.AddTransient<Domain.Interfaces.Services.Fornecedor.IFornecedorLojaService, Domain.Services.Fornecedor.FornecedorLojaService> ();
            services.AddTransient<Domain.Interfaces.Services.Fornecedor.IFornecedorLojaService, Domain.Services.Fornecedor.FornecedorLojaService> ();
            services.AddTransient<Domain.Interfaces.Services.OC.IOCDetalhesService, Domain.Services.OC.OCDetalhesService> ();
            services.AddTransient<Domain.Interfaces.Services.OC.IOCFaturaService, Domain.Services.OC.OCFaturaService> ();
            services.AddTransient<Domain.Interfaces.Services.OC.IOCMensagemService, Domain.Services.OC.OCMensagemService> ();
            services.AddTransient<Domain.Interfaces.Services.OC.IOCPagamentoService, Domain.Services.OC.OCPagamentoService> ();
            services.AddTransient<Domain.Interfaces.Services.OC.IOCRetornoStatusService, Domain.Services.OC.OCRetornoStatusService> ();
            services.AddTransient<Domain.Interfaces.Services.OC.IOCService, Domain.Services.OC.OCService> ();
            services.AddTransient<Domain.Interfaces.Services.OC.IOCStatusAppService, Domain.Services.OC.OCStatusService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.IAtributoService, Domain.Services.Produto.AtributoService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.ICategoriaLojaService, Domain.Services.Produto.CategoriaLojaService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.ICategoriaProdutoService, Domain.Services.Produto.CategoriaProdutoService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.ICategoriaService, Domain.Services.Produto.CategoriaService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.IIndexPesquisaService, Domain.Services.Produto.IndexPesquisaService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.IProdutoFornecedorService, Domain.Services.Produto.ProdutoFornecedorService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.IProdutoGrupoService, Domain.Services.Produto.ProdutoGrupoService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.IProdutoImagemService, Domain.Services.Produto.ProdutoImagemService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.IProdutoLojaService, Domain.Services.Produto.ProdutoLojaService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.IProdutoPropriedadeService, Domain.Services.Produto.ProdutoPropriedadeService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.IProdutoService, Domain.Services.Produto.ProdutoService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.IProdutoTagService, Domain.Services.Produto.ProdutoTagService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.IProdutoTransportadoraService, Domain.Services.Produto.ProdutoTransportadoraService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.IPropriedadeService, Domain.Services.Produto.PropriedadeService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.IPropriedadeValorService, Domain.Services.Produto.PropriedadeValorService> ();
            services.AddTransient<Domain.Interfaces.Services.Produto.ITagService, Domain.Services.Produto.TagService> ();
            services.AddTransient<Domain.Interfaces.Services.Transportadora.IEntregaService, Domain.Services.Transportadora.EntregaService> ();
            services.AddTransient<Domain.Interfaces.Services.Transportadora.IFaixaDePesoService, Domain.Services.Transportadora.FaixaDePesoService> ();
            services.AddTransient<Domain.Interfaces.Services.Transportadora.IFaixaDePrecoService, Domain.Services.Transportadora.FaixaDePrecoService> ();
            services.AddTransient<Domain.Interfaces.Services.Transportadora.ITransportadoraLojaService, Domain.Services.Transportadora.TransportadoraLojaService> ();
            services.AddTransient<Domain.Interfaces.Services.Transportadora.ITransportadoraService, Domain.Services.Transportadora.TransportadoraService> ();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();
            app.UseSession();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                 name: "areas",
                 template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
               );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
