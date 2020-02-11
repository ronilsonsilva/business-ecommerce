using Microsoft.EntityFrameworkCore;
using SCommerce.Infra.Data.EF.Map;
using SCommerce.Infra.Data.EF.Map.CadastroBase;
using SCommerce.Infra.Data.EF.Map.Carrinho;
using SCommerce.Infra.Data.EF.Map.Cliente;
using SCommerce.Infra.Data.EF.Map.CMS;
using SCommerce.Infra.Data.EF.Map.Empregado;
using SCommerce.Infra.Data.EF.Map.Fabricante;
using SCommerce.Infra.Data.EF.Map.Financeiro;
using SCommerce.Infra.Data.EF.Map.Fornecedor;
using SCommerce.Infra.Data.EF.Map.OC;
using SCommerce.Infra.Data.EF.Map.Produto;
using SCommerce.Infra.Data.EF.Map.Transportadora;
using SCommerce.Domain.Entities;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Carrinho;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Entities.CMS;
using SCommerce.Domain.Entities.Empregado;
using SCommerce.Domain.Entities.Fabricante;
using SCommerce.Domain.Entities.Financeiro;
using SCommerce.Domain.Entities.Fornecedor;
using SCommerce.Domain.Entities.OC;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Entities.Transportadora;
using JetBrains.Annotations;

namespace SCommerce.Infra.Data.EF
{
    public class ScContext : DbContext
    {
        /***************************************** Base de desenvolvimento ****************************************/
        //public static string ConnectionString = @"Server=68.66.228.7;Database=sousasil_scommerce_dev;User Id=sousasil_admin;Password=Siga2018;";

        /***************************************** Base de teste ****************************************/
        //public static string ConnectionString = @"Server=68.66.228.7;Database=sousasil_bcommerce_teste;User Id=sousasil_admin;Password=Siga2018;";

        /**************************** Raquel Lopes Modas ******************************************/
        //public static string ConnectionString = @"Server=68.66.228.7;Database=sousasil_raquelllopes;User Id=sousasil_admin;Password=Siga2018;";

        /**************************** Equinocio Moda Feminina ******************************************/
        //public static string ConnectionString = @"Server=68.66.228.7;Database=sousasil_equinocio_modas;User Id=sousasil_admin;Password=Siga2018;";

        /***************************************** Localhost ****************************************/
        //public static string ConnectionString = @"Server=DESKTOP-EEQ8PMR\SQLEXPRESS;Initial Catalog=sousasil_scommerce_dev;MultipleActiveResultSets=true;Integrated Security=True";

        /***************************************** Base de Producao ****************************************/
        //public static string ConnectionString = @"host=127.0.0.1;port=64402;database=SS_BusinessCommerce;user id=root;password=#@ijyHQ0; providerName=Npgsql";
        //public static string ConnectionString = @"Server=127.0.0.1;Port=5432;Database=SS_BCommerce;User Id=postgres;Password=#@ijyHQ0;";

        /***************************************** Base de Desenvolvimento ****************************************/
        public static string ConnectionString = @"Server=167.86.112.71;Port=5432;Database=SS_BCommerce;User Id=postgres;Password=#@ijyHQ0;";

        #region DbSets
        //CadastroBase
        public DbSet<Anexo> Anexo { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<ContatoLojaEmail> ContatoLojaEmail { get; set; }
        public DbSet<ContatoLojaEndereco> ContatoLojaEndereco { get; set; }
        public DbSet<ContatoLoja> ContatoLoja { get; set; }
        public DbSet<ContatoLojaRedeSocial> ContatoLojaRedeSocial { get; set; }
        public DbSet<ContatoLojaTelefone> ContatoLojaTelefone { get; set; }
        public DbSet<ContatoTelefone> ContatoTelefone { get; set; }
        public DbSet<ContatoEmail> ContatoEmails { get; set; }
        public DbSet<ContatoRedeSocial> ContatoRedeSocials { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Domain.Entities.CadastroBase.Grupo> Grupo { get; set; }
        public DbSet<LojaDepartamento> LojaDepartamento { get; set; }
        public DbSet<LojaImagens> LojaImagens { get; set; }
        public DbSet<Loja> Loja { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Regiao> Regiao { get; set; }
        public DbSet<SistemaOperacional> SistemaOperacional { get; set; }
        public DbSet<WebBrownser> WebBrownser { get; set; }
        public DbSet<Pais> Pais { get; set; }

        //Carrinho
        public DbSet<Carrinho> Carrinho { get; set; }
        public DbSet<CarrinhoProduto> CarrinhoProdutos { get; set; }

        //Cliente
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ClienteMensagem> ClienteMensagem { get; set; }
        public DbSet<ClienteProcesso> ClienteProcesso { get; set; }

        //CMS
        public DbSet<CMSCategoria> CMSCategoria { get; set; }
        public DbSet<CMSLoja> CMSLoja { get; set; }
        public DbSet<CMS> CMS { get; set; }
        public DbSet<CMSSlidePrincipal> CMSSlidePrincipals { get; set; }
        public DbSet<CMSEnderecoLoja> CMSEnderecoLojas { get; set; }
        public DbSet<CMSRedeSocial> CMSRedeSocials { get; set; }
        public DbSet<CMSWhatsApp> CMSWhatsApps { get; set; }

        //Empregado
        public DbSet<Acesso> Acesso { get; set; }
        public DbSet<EmpregadoEndereco> EmpregadoEndereco { get; set; }
        public DbSet<EmpregadoLoja> EmpregadoLoja { get; set; }
        public DbSet<Empregado> Empregado { get; set; }
        public DbSet<EmpregadoOC> EmpregadoOC { get; set; }
        public DbSet<Modulo> Modulo { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        

        //Fabricante
        public DbSet<FabricanteFornecedor> FabricanteFornecedor { get; set; }
        public DbSet<FabricanteLoja> FabricanteLoja { get; set; }
        public DbSet<Fabricante> Fabricante { get; set; }
        public DbSet<FabricanteProduto> FabricanteProduto { get; set; }

        //Fianceiro
        public DbSet<MetodoPagamento> MetodoPagamento { get; set; }
        public DbSet<Moeda> Moeda { get; set; }

        //Fornecedor
        public DbSet<FornecedorLoja> FornecedorLoja { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }

        //OC
        public DbSet<OCFatura> OCFatura { get; set; }
        public DbSet<OC> OC { get; set; }
        public DbSet<OCDetalhes> OCDetalhes { get; set; }
        public DbSet<OCMensagem> OCMensagem { get; set; }
        public DbSet<OCPagamento> OCPagamento { get; set; }
        public DbSet<OCStatus> OCStatus { get; set; }

        //Produto
        public DbSet<Atributo> Atributo { get; set; }
        public DbSet<CategoriaLoja> CategoriaLoja { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
        public DbSet<ProdutoFornecedor> ProdutoFornecedor { get; set; }
        public DbSet<ProdutoGrupo> ProdutoGrupo { get; set; }
        public DbSet<ProdutoImagem> ProdutoImagem { get; set; }
        public DbSet<ProdutoPropriedade> ProdutoPropriedade { get; set; }
        public DbSet<ProdutoTag> ProdutoTag { get; set; }
        public DbSet<ProdutoLoja> ProdutoLoja { get; set; }
        public DbSet<ProdutoTransportadora> ProdutoTransportadora { get; set; }
        public DbSet<Propriedade> Propriedade { get; set; }
        public DbSet<PropriedadeValor> PropriedadeValor { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ProdutoPromocao> ProdutoPromocaos { get; set; }
        

        //Transportadora
        public DbSet<Entrega> Entrega { get; set; }
        public DbSet<FaixaDePeso> FaixaDePeso { get; set; }
        public DbSet<FaixaDePreco> FaixaDePreco { get; set; }
        public DbSet<TransportadoraEndereco> TransportadoraEndereco { get; set; }
        public DbSet<TransportadoraLoja> TransportadoraLoja { get; set; }
        public DbSet<Transportadora> Transportadora { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
            //optionsBuilder.UseSqlServer(ConnectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //ignorar classes
           
            //modelBuilder.Ignore<Domain.Entities.OC.OCDetalhes>();
            modelBuilder.Ignore<Domain.Entities.OC.OCRetornoStatus>();
            modelBuilder.Ignore<Domain.Entities.Produto.IndexPesquisa>();
            modelBuilder.Ignore<Domain.Entities.Cliente.Contato>();
            //modelBuilder.Ignore<Domain.Entities.CadastroBase.ContatoTelefone>();


            //aplicar configurações
            modelBuilder.ApplyConfiguration(new AnexoMap());
            modelBuilder.ApplyConfiguration(new CidadeMap());
            modelBuilder.ApplyConfiguration(new ContatoLojaEmailMap());
            modelBuilder.ApplyConfiguration(new ContatoLojaEnderecoMap());
            modelBuilder.ApplyConfiguration(new ContatoTelefoneMap());
            modelBuilder.ApplyConfiguration(new ContatoLojaMap());
            modelBuilder.ApplyConfiguration(new ContatoLojaRedeSocialMap());
            modelBuilder.ApplyConfiguration(new ContatoLojaTelefoneMap());
            modelBuilder.ApplyConfiguration(new DepartamentoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new Map.CadastroBase.GrupoMap());
            modelBuilder.ApplyConfiguration(new LojaDepartamentoMap());
            modelBuilder.ApplyConfiguration(new LojaImagensMap());
            modelBuilder.ApplyConfiguration(new LojaMap());
            modelBuilder.ApplyConfiguration(new PaisMap());
            modelBuilder.ApplyConfiguration(new ProvinciaMap());
            modelBuilder.ApplyConfiguration(new RegiaoMap());
            modelBuilder.ApplyConfiguration(new SistemaOperacionalMap());
            modelBuilder.ApplyConfiguration(new WebBrownserMap());
            modelBuilder.ApplyConfiguration(new CarrinhoMap());
            modelBuilder.ApplyConfiguration(new CarrinhoProdutoMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ClienteMensagemMap());
            modelBuilder.ApplyConfiguration(new ClienteProcessoMap());
            modelBuilder.ApplyConfiguration(new CMSLojaMap());
            modelBuilder.ApplyConfiguration(new AcessoMap());
            modelBuilder.ApplyConfiguration(new EmpregadoEnderecoMap());
            modelBuilder.ApplyConfiguration(new EmpregadoLojaMap());
            modelBuilder.ApplyConfiguration(new EmpregadoMap());
            modelBuilder.ApplyConfiguration(new EmpregadoOCMap());
            modelBuilder.ApplyConfiguration(new ModuloMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
            modelBuilder.ApplyConfiguration(new FabricanteFornecedorMap());
            modelBuilder.ApplyConfiguration(new FabricanteLojaMap());
            modelBuilder.ApplyConfiguration(new FabricanteMap());
            modelBuilder.ApplyConfiguration(new FabricanteProdutoMap());
            modelBuilder.ApplyConfiguration(new MetodoPagamentoMap());
            modelBuilder.ApplyConfiguration(new MoedaMap());
            modelBuilder.ApplyConfiguration(new FornecedorLojaMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new OCFaturaMap());
            modelBuilder.ApplyConfiguration(new OCMap());
            modelBuilder.ApplyConfiguration(new OCMensagemMap());
            modelBuilder.ApplyConfiguration(new OCPagamentoMap());
            modelBuilder.ApplyConfiguration(new OCStatusMap());
            modelBuilder.ApplyConfiguration(new CategoriaLojaMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new ProdutoFornecedorMap());
            modelBuilder.ApplyConfiguration(new ProdutoGrupoMap());
            modelBuilder.ApplyConfiguration(new ProdutoImagemMap());
            modelBuilder.ApplyConfiguration(new ProdutoPropriedadeMap());
            modelBuilder.ApplyConfiguration(new ProdutoTagMap());
            modelBuilder.ApplyConfiguration(new ProdutoTransportadoraMap());
            modelBuilder.ApplyConfiguration(new PropriedadeMap());
            modelBuilder.ApplyConfiguration(new PropriedadeValorMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new EntregaMap());
            modelBuilder.ApplyConfiguration(new FaixaDePesoMap());
            modelBuilder.ApplyConfiguration(new FaixaDePrecoMap());
            modelBuilder.ApplyConfiguration(new TransportadoraEnderecoMap());
            modelBuilder.ApplyConfiguration(new TransportadoraLojaMap());
            modelBuilder.ApplyConfiguration(new TransportadoraMap());
            modelBuilder.ApplyConfiguration(new ProdutoPromocaoMAP());
            modelBuilder.ApplyConfiguration(new CMSEnderecoLojaMAP());
            modelBuilder.ApplyConfiguration(new CMSRedeSocialMAP());
            modelBuilder.ApplyConfiguration(new CMSSlidePrincipalMAP());
            modelBuilder.ApplyConfiguration(new CMSWhatsAppMAP());
            modelBuilder.ApplyConfiguration(new OCDetalhesMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
