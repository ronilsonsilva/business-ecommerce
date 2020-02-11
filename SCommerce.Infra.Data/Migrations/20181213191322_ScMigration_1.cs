using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCommerce.Infra.Data.Migrations
{
    public partial class ScMigration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IDCategoriaPai = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    LevelDepth = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Root = table.Column<bool>(nullable: false),
                    NLeft = table.Column<int>(nullable: false),
                    NRight = table.Column<int>(nullable: false),
                    Posicao = table.Column<int>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Usuario = table.Column<string>(nullable: false),
                    GeneroCliente = table.Column<string>(nullable: true),
                    Companhia = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    NewsLetter = table.Column<bool>(nullable: false),
                    CadastroNewsLetter = table.Column<bool>(nullable: false),
                    Website = table.Column<string>(nullable: true),
                    PermissoesPendente = table.Column<int>(nullable: false),
                    ExibirPrecosPublicos = table.Column<bool>(nullable: false),
                    MaxDiasPagamentos = table.Column<int>(nullable: false),
                    ChaveSeguranca = table.Column<string>(nullable: true),
                    Nota = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Visitante = table.Column<bool>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CMSCategoria",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    IdPai = table.Column<Guid>(nullable: false),
                    Posicao = table.Column<int>(nullable: false),
                    LevelDepth = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSCategoria", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ContatoEmail",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    NomeContato = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatoEmail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ContatoRedeSocial",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RedeSocial = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    IdentificadorUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatoRedeSocial", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    NomeExibir = table.Column<string>(nullable: true),
                    IdPai = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fabricante",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricante", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MetodoPagamento",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Observacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodoPagamento", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Modulo",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdPai = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Detalhes = table.Column<string>(nullable: true),
                    Posicao = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    HideHostMode = table.Column<bool>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Moeda",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    CodigoIso = table.Column<string>(nullable: false),
                    sign = table.Column<string>(nullable: true),
                    CodigoIsoNumerico = table.Column<int>(nullable: false),
                    EmBRanco = table.Column<bool>(nullable: false),
                    Formato = table.Column<bool>(nullable: false),
                    Decimal = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    TaxaConversao = table.Column<decimal>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moeda", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OCStatus",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Faturado = table.Column<bool>(nullable: false),
                    EnviarEmail = table.Column<bool>(nullable: false),
                    NaoRemovivel = table.Column<bool>(nullable: false),
                    Oculto = table.Column<bool>(nullable: false),
                    Logable = table.Column<bool>(nullable: false),
                    Entregado = table.Column<bool>(nullable: false),
                    Enviado = table.Column<bool>(nullable: false),
                    Pago = table.Column<bool>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    Cancelado = table.Column<bool>(nullable: false),
                    ModuloNome = table.Column<string>(nullable: true),
                    Cor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Codigo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Propriedade",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdPai = table.Column<Guid>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Customizavel = table.Column<bool>(nullable: false),
                    ValorUnico = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propriedade", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Regiao",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Ativa = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiao", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SistemaOperacional",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaOperacional", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transportadora",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    NomeModuloExterno = table.Column<string>(nullable: true),
                    MetodoEnvio = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    ShippingHandling = table.Column<bool>(nullable: false),
                    RangeBehavior = table.Column<bool>(nullable: false),
                    Modulo = table.Column<bool>(nullable: false),
                    Gratis = table.Column<bool>(nullable: false),
                    EnvioExterno = table.Column<bool>(nullable: false),
                    NeedRange = table.Column<bool>(nullable: false),
                    Posicao = table.Column<int>(nullable: false),
                    AlturaMaxima = table.Column<decimal>(nullable: false),
                    ProfundidadeMaxima = table.Column<decimal>(nullable: false),
                    PesoMaximo = table.Column<decimal>(nullable: false),
                    Grade = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportadora", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WebBrownser",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebBrownser", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ContatoTelefone",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    CodigoLocal = table.Column<int>(nullable: false),
                    CodigoNacional = table.Column<int>(nullable: false),
                    Operadora = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    TipoContato = table.Column<int>(nullable: false),
                    IdCliente = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatoTelefone", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContatoTelefone_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CMS",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CMSCategoriaID = table.Column<Guid>(nullable: true),
                    Posicao = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Indexado = table.Column<bool>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CMS_CMSCategoria_CMSCategoriaID",
                        column: x => x.CMSCategoriaID,
                        principalTable: "CMSCategoria",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FabricanteFornecedor",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdFornecedor = table.Column<Guid>(nullable: false),
                    IdFabricante = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FabricanteFornecedor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FabricanteFornecedor_Fabricante_IdFabricante",
                        column: x => x.IdFabricante,
                        principalTable: "Fabricante",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FabricanteFornecedor_Fornecedor_IdFornecedor",
                        column: x => x.IdFornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    CodigoISO = table.Column<string>(nullable: true),
                    ImpostoPermitido = table.Column<decimal>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    IdPais = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Provincia_Pais_IdPais",
                        column: x => x.IdPais,
                        principalTable: "Pais",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Acesso",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Comentario = table.Column<string>(nullable: true),
                    IdPerfil = table.Column<Guid>(nullable: false),
                    IdModulo = table.Column<Guid>(nullable: false),
                    View = table.Column<bool>(nullable: false),
                    Edit = table.Column<bool>(nullable: false),
                    Delete = table.Column<bool>(nullable: false),
                    Create = table.Column<bool>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false),
                    PerfilID1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acesso", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Acesso_Modulo_IdModulo",
                        column: x => x.IdModulo,
                        principalTable: "Modulo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acesso_Perfil_IdPerfil",
                        column: x => x.IdPerfil,
                        principalTable: "Perfil",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acesso_Perfil_PerfilID1",
                        column: x => x.PerfilID1,
                        principalTable: "Perfil",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empregado",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdPerfil = table.Column<Guid>(nullable: false),
                    PerfilID = table.Column<Guid>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Usuario = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    UltimaConexao = table.Column<DateTime>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empregado", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Empregado_Perfil_PerfilID",
                        column: x => x.PerfilID,
                        principalTable: "Perfil",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropriedadeValor",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdPropriedade = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Valor = table.Column<string>(nullable: true),
                    TipoDado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropriedadeValor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PropriedadeValor_Propriedade_IdPropriedade",
                        column: x => x.IdPropriedade,
                        principalTable: "Propriedade",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaixaDePeso",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdTransportadora = table.Column<Guid>(nullable: false),
                    Delimitador1 = table.Column<decimal>(nullable: false),
                    Delimitador2 = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaixaDePeso", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FaixaDePeso_Transportadora_IdTransportadora",
                        column: x => x.IdTransportadora,
                        principalTable: "Transportadora",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaixaDePreco",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdTransportadora = table.Column<Guid>(nullable: false),
                    Delimitador1 = table.Column<decimal>(nullable: false),
                    Delimitador2 = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaixaDePreco", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FaixaDePreco_Transportadora_IdTransportadora",
                        column: x => x.IdTransportadora,
                        principalTable: "Transportadora",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loja",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    LojaMatriz = table.Column<Guid>(nullable: false),
                    Matriz = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    RazaoSocial = table.Column<string>(nullable: true),
                    CNPJ = table.Column<string>(nullable: true),
                    InscricaoEstadual = table.Column<string>(nullable: true),
                    Ativa = table.Column<bool>(nullable: false),
                    Deletada = table.Column<bool>(nullable: false),
                    Cadatro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false),
                    CMSID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loja", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Loja_CMS_CMSID",
                        column: x => x.CMSID,
                        principalTable: "CMS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdProvincia = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cidade_Provincia_IdProvincia",
                        column: x => x.IdProvincia,
                        principalTable: "Provincia",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carrinho",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    OpcaoEnvio = table.Column<string>(nullable: true),
                    ChaveSeguranca = table.Column<string>(nullable: true),
                    Reciclavel = table.Column<bool>(nullable: false),
                    PermitirPacoteSeparado = table.Column<bool>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false),
                    IdCliente = table.Column<Guid>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinho", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Carrinho_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carrinho_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaLoja",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Posicao = table.Column<int>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false),
                    IdCategoria = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaLoja", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoriaLoja_Categoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaLoja_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CMSLoja",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false),
                    IconeType = table.Column<string>(nullable: true),
                    Icone = table.Column<byte[]>(nullable: true),
                    LogoType = table.Column<string>(nullable: true),
                    Logo = table.Column<byte[]>(nullable: true),
                    LogoType2 = table.Column<string>(nullable: true),
                    Logo2 = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSLoja", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CMSLoja_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CMSRedeSocial",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    IconeType = table.Column<string>(nullable: true),
                    Icone = table.Column<byte[]>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSRedeSocial", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CMSRedeSocial_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContatoLoja",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NomeContato = table.Column<string>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatoLoja", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContatoLoja_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpregadoLoja",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdEmpregado = table.Column<Guid>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false),
                    EmpregadoID1 = table.Column<Guid>(nullable: true),
                    LojaID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpregadoLoja", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmpregadoLoja_Empregado_EmpregadoID1",
                        column: x => x.EmpregadoID1,
                        principalTable: "Empregado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpregadoLoja_Empregado_IdEmpregado",
                        column: x => x.IdEmpregado,
                        principalTable: "Empregado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpregadoLoja_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpregadoLoja_Loja_LojaID",
                        column: x => x.LojaID,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FabricanteLoja",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false),
                    IdFabricante = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FabricanteLoja", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FabricanteLoja_Fabricante_IdFabricante",
                        column: x => x.IdFabricante,
                        principalTable: "Fabricante",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FabricanteLoja_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FornecedorLoja",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdFornecedor = table.Column<Guid>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FornecedorLoja", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FornecedorLoja_Fornecedor_IdFornecedor",
                        column: x => x.IdFornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FornecedorLoja_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LojaDepartamento",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false),
                    IdDepartamento = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LojaDepartamento", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LojaDepartamento_Departamento_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Departamento",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LojaDepartamento_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LojaImagens",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Arquivo = table.Column<byte[]>(nullable: false),
                    Formato = table.Column<string>(nullable: false),
                    Logomarca = table.Column<bool>(nullable: false),
                    Icone = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LojaImagens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LojaImagens_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OC",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Referencia = table.Column<string>(nullable: true),
                    NumeroEnvio = table.Column<string>(nullable: true),
                    DescontoTotal = table.Column<decimal>(nullable: false),
                    PagamentoTotal = table.Column<decimal>(nullable: false),
                    PagamentoReal = table.Column<decimal>(nullable: false),
                    ProdutoTotal = table.Column<decimal>(nullable: false),
                    TotalEnviado = table.Column<decimal>(nullable: false),
                    DataEnvio = table.Column<DateTime>(nullable: false),
                    Valido = table.Column<bool>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false),
                    IdMetotoPagamento = table.Column<Guid>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false),
                    IdCliente = table.Column<Guid>(nullable: false),
                    IdOCStatus = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OC", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OC_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OC_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OC_MetodoPagamento_IdMetotoPagamento",
                        column: x => x.IdMetotoPagamento,
                        principalTable: "MetodoPagamento",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OC_OCStatus_IdOCStatus",
                        column: x => x.IdOCStatus,
                        principalTable: "OCStatus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Disponivel = table.Column<bool>(nullable: false),
                    SomenteOnline = table.Column<bool>(nullable: false),
                    EAN13 = table.Column<string>(nullable: true),
                    UPC = table.Column<string>(nullable: true),
                    Ecotax = table.Column<decimal>(nullable: false),
                    QuantidadeMinima = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Preco = table.Column<decimal>(nullable: false),
                    PrecoAtacado = table.Column<decimal>(nullable: false),
                    Unidade = table.Column<string>(nullable: true),
                    Referencia = table.Column<string>(nullable: true),
                    ReferenciaFornecedor = table.Column<string>(nullable: true),
                    ReferenciaFabricante = table.Column<string>(nullable: true),
                    ImpactoPrecoUnitario = table.Column<decimal>(nullable: false),
                    CustoEnvio = table.Column<decimal>(nullable: false),
                    Largura = table.Column<decimal>(nullable: false),
                    Altura = table.Column<decimal>(nullable: false),
                    Profundidade = table.Column<decimal>(nullable: false),
                    Peso = table.Column<decimal>(nullable: false),
                    ForaDeEstoque = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Customizavel = table.Column<bool>(nullable: false),
                    UploadArquivos = table.Column<bool>(nullable: false),
                    CampoTexto = table.Column<bool>(nullable: false),
                    DisponivelParaOC = table.Column<bool>(nullable: false),
                    ExibirPreco = table.Column<bool>(nullable: false),
                    Indexado = table.Column<bool>(nullable: false),
                    TemAnexoOculto = table.Column<bool>(nullable: false),
                    ProdutoDigital = table.Column<bool>(nullable: false),
                    GerenciamentoAvancadoEstoque = table.Column<bool>(nullable: false),
                    DescontoPorQuantidade = table.Column<bool>(nullable: false),
                    Condicao = table.Column<int>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    NomeExibicao = table.Column<string>(nullable: true),
                    DescricaoCurta = table.Column<string>(nullable: true),
                    IdCategoriaPadrao = table.Column<Guid>(nullable: false),
                    CategoriaPadraoID = table.Column<Guid>(nullable: true),
                    IdLojaPadrao = table.Column<Guid>(nullable: false),
                    LojaPadraoID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_CategoriaPadraoID",
                        column: x => x.CategoriaPadraoID,
                        principalTable: "Categoria",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produto_Loja_LojaPadraoID",
                        column: x => x.LojaPadraoID,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransportadoraLoja",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false),
                    IdTransportadora = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportadoraLoja", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TransportadoraLoja_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportadoraLoja_Transportadora_IdTransportadora",
                        column: x => x.IdTransportadora,
                        principalTable: "Transportadora",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Aliase = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    CodigoPostal = table.Column<string>(nullable: true),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    IdCidade = table.Column<Guid>(nullable: false),
                    IdCliente = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Endereco_Cidade_IdCidade",
                        column: x => x.IdCidade,
                        principalTable: "Cidade",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Endereco_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContatoLojaEmail",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdContatoLoja = table.Column<Guid>(nullable: false),
                    IdContatoEmail = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatoLojaEmail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContatoLojaEmail_ContatoEmail_IdContatoEmail",
                        column: x => x.IdContatoEmail,
                        principalTable: "ContatoEmail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContatoLojaEmail_ContatoLoja_IdContatoLoja",
                        column: x => x.IdContatoLoja,
                        principalTable: "ContatoLoja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContatoLojaRedeSocial",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdContatoRedeSocial = table.Column<Guid>(nullable: false),
                    IdContatoLoja = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatoLojaRedeSocial", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContatoLojaRedeSocial_ContatoLoja_IdContatoLoja",
                        column: x => x.IdContatoLoja,
                        principalTable: "ContatoLoja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContatoLojaRedeSocial_ContatoRedeSocial_IdContatoRedeSocial",
                        column: x => x.IdContatoRedeSocial,
                        principalTable: "ContatoRedeSocial",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContatoLojaTelefone",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdContatoLoja = table.Column<Guid>(nullable: false),
                    IdContatoTelefone = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatoLojaTelefone", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContatoLojaTelefone_ContatoLoja_IdContatoLoja",
                        column: x => x.IdContatoLoja,
                        principalTable: "ContatoLoja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContatoLojaTelefone_ContatoTelefone_IdContatoTelefone",
                        column: x => x.IdContatoTelefone,
                        principalTable: "ContatoTelefone",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClienteProcesso",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    IdOC = table.Column<Guid>(nullable: false),
                    ClienteID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteProcesso", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClienteProcesso_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClienteProcesso_OC_IdOC",
                        column: x => x.IdOC,
                        principalTable: "OC",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpregadoOC",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdEmpregado = table.Column<Guid>(nullable: false),
                    IdOC = table.Column<Guid>(nullable: false),
                    EmpregadoID1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpregadoOC", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmpregadoOC_Empregado_EmpregadoID1",
                        column: x => x.EmpregadoID1,
                        principalTable: "Empregado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpregadoOC_Empregado_IdEmpregado",
                        column: x => x.IdEmpregado,
                        principalTable: "Empregado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpregadoOC_OC_IdOC",
                        column: x => x.IdOC,
                        principalTable: "OC",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entrega",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Preco = table.Column<decimal>(nullable: false),
                    Peso = table.Column<decimal>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    IdTransportadora = table.Column<Guid>(nullable: false),
                    IdOC = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrega", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Entrega_OC_IdOC",
                        column: x => x.IdOC,
                        principalTable: "OC",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entrega_Transportadora_IdTransportadora",
                        column: x => x.IdTransportadora,
                        principalTable: "Transportadora",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OCFatura",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    NumeroEntrega = table.Column<int>(nullable: false),
                    Entrega = table.Column<DateTime>(nullable: false),
                    ImpostoExlusaoTotal = table.Column<decimal>(nullable: false),
                    ImpostoInlusaoTotal = table.Column<decimal>(nullable: false),
                    ImpostoInlusaoPago = table.Column<decimal>(nullable: false),
                    ImpostoExlusaoPago = table.Column<decimal>(nullable: false),
                    TotalProdutosWT = table.Column<decimal>(nullable: false),
                    TotalImpostoExclusaoEnvio = table.Column<decimal>(nullable: false),
                    TotalImpostoInclusaoEnvio = table.Column<decimal>(nullable: false),
                    Nota = table.Column<string>(nullable: true),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false),
                    IdOC = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCFatura", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OCFatura_OC_IdOC",
                        column: x => x.IdOC,
                        principalTable: "OC",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OCMensagem",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Lida = table.Column<bool>(nullable: false),
                    Privada = table.Column<bool>(nullable: false),
                    Mensagem = table.Column<string>(nullable: true),
                    IdOC = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCMensagem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OCMensagem_OC_IdOC",
                        column: x => x.IdOC,
                        principalTable: "OC",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Atributo",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ProdutoID = table.Column<Guid>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Custmizavel = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atributo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Atributo_Produto_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarrinhoProduto",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdCarrinho = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoProduto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarrinhoProduto_Carrinho_IdCarrinho",
                        column: x => x.IdCarrinho,
                        principalTable: "Carrinho",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoProduto_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaProduto",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    IdCategoria = table.Column<Guid>(nullable: false),
                    ProdutoID = table.Column<Guid>(nullable: true),
                    CategoriaID = table.Column<Guid>(nullable: true),
                    Posicao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaProduto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoriaProduto_Categoria_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categoria",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoriaProduto_Produto_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FabricanteProduto",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    IdFabricante = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FabricanteProduto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FabricanteProduto_Fabricante_IdFabricante",
                        column: x => x.IdFabricante,
                        principalTable: "Fabricante",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FabricanteProduto_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OCDetalhes",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    IdOC = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCDetalhes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OCDetalhes_OC_IdOC",
                        column: x => x.IdOC,
                        principalTable: "OC",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OCDetalhes_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoCategoria",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    IdCategoria = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoCategoria", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProdutoCategoria_Categoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoCategoria_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoFornecedor",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    IdFornecedor = table.Column<Guid>(nullable: false),
                    ReferenciaFornecedor = table.Column<string>(nullable: true),
                    PrecoFornecedor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoFornecedor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProdutoFornecedor_Fornecedor_IdFornecedor",
                        column: x => x.IdFornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoFornecedor_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoGrupo",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    IdGrupo = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoGrupo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProdutoGrupo_Grupo_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Grupo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoGrupo_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoImagem",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    Arquivo = table.Column<byte[]>(nullable: true),
                    Formato = table.Column<string>(nullable: true),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizada = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoImagem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProdutoImagem_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoLoja",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    IdLoja = table.Column<Guid>(nullable: false),
                    Disponivel = table.Column<bool>(nullable: false),
                    SomenteOnline = table.Column<bool>(nullable: false),
                    ProdutoDigital = table.Column<bool>(nullable: false),
                    QuantidadeMinima = table.Column<int>(nullable: false),
                    Preco = table.Column<decimal>(nullable: false),
                    PrecoAtacado = table.Column<decimal>(nullable: false),
                    PrecoUnitario = table.Column<decimal>(nullable: false),
                    CustoEnvio = table.Column<decimal>(nullable: false),
                    Unidade = table.Column<string>(nullable: true),
                    Customizavel = table.Column<bool>(nullable: false),
                    UploadArquivos = table.Column<bool>(nullable: false),
                    CampoTexto = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    DisponiveParaOC = table.Column<bool>(nullable: false),
                    DataDisponibilidade = table.Column<DateTime>(nullable: false),
                    SituacaoProduto = table.Column<int>(nullable: false),
                    ExibirPreco = table.Column<bool>(nullable: false),
                    Indexado = table.Column<bool>(nullable: false),
                    GerenciamentoAvancadoEstoque = table.Column<bool>(nullable: false),
                    VisibilidadeProduto = table.Column<int>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoLoja", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProdutoLoja_Loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "Loja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoLoja_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoPropriedade",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdPropriedade = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoPropriedade", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProdutoPropriedade_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoPropriedade_Propriedade_IdPropriedade",
                        column: x => x.IdPropriedade,
                        principalTable: "Propriedade",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoTag",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    IdTag = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoTag", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProdutoTag_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoTag_Tag_IdTag",
                        column: x => x.IdTag,
                        principalTable: "Tag",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoTransportadora",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    IdTransportadora = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoTransportadora", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProdutoTransportadora_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoTransportadora_Transportadora_IdTransportadora",
                        column: x => x.IdTransportadora,
                        principalTable: "Transportadora",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContatoLojaEndereco",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdContatoLoja = table.Column<Guid>(nullable: false),
                    IdEndereco = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatoLojaEndereco", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContatoLojaEndereco_ContatoLoja_IdContatoLoja",
                        column: x => x.IdContatoLoja,
                        principalTable: "ContatoLoja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContatoLojaEndereco_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpregadoEndereco",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdEmpregado = table.Column<Guid>(nullable: false),
                    IdEndereco = table.Column<Guid>(nullable: false),
                    EmpregadoID1 = table.Column<Guid>(nullable: true),
                    EnderecoID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpregadoEndereco", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmpregadoEndereco_Empregado_EmpregadoID1",
                        column: x => x.EmpregadoID1,
                        principalTable: "Empregado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpregadoEndereco_Endereco_EnderecoID",
                        column: x => x.EnderecoID,
                        principalTable: "Endereco",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpregadoEndereco_Empregado_IdEmpregado",
                        column: x => x.IdEmpregado,
                        principalTable: "Empregado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpregadoEndereco_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransportadoraEndereco",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdTranportadora = table.Column<Guid>(nullable: false),
                    IdEndereco = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportadoraEndereco", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TransportadoraEndereco_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportadoraEndereco_Transportadora_IdTranportadora",
                        column: x => x.IdTranportadora,
                        principalTable: "Transportadora",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CMSWhatsApp",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    Exibir = table.Column<bool>(nullable: false),
                    Principal = table.Column<bool>(nullable: false),
                    IDContatoLojaTelefone = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSWhatsApp", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CMSWhatsApp_ContatoLojaTelefone_IDContatoLojaTelefone",
                        column: x => x.IDContatoLojaTelefone,
                        principalTable: "ContatoLojaTelefone",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClienteMensagem",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdClienteProcesso = table.Column<Guid>(nullable: false),
                    Mensagem = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    Editada = table.Column<DateTime>(nullable: false),
                    Privada = table.Column<bool>(nullable: false),
                    Lida = table.Column<bool>(nullable: false),
                    Audio = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteMensagem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClienteMensagem_ClienteProcesso_IdClienteProcesso",
                        column: x => x.IdClienteProcesso,
                        principalTable: "ClienteProcesso",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OCPagamento",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    OCReferencia = table.Column<string>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    TaxaConversao = table.Column<decimal>(nullable: false),
                    NumeroCartao = table.Column<string>(nullable: true),
                    BandeiraCartao = table.Column<string>(nullable: true),
                    CartaoVencimento = table.Column<DateTime>(nullable: false),
                    TitularCartao = table.Column<string>(nullable: true),
                    TitularCPF = table.Column<string>(nullable: true),
                    NascimentoTitular = table.Column<DateTime>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false),
                    IdOCFatura = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCPagamento", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OCPagamento_OCFatura_IdOCFatura",
                        column: x => x.IdOCFatura,
                        principalTable: "OCFatura",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Anexo",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Tipo = table.Column<string>(nullable: false),
                    Arquivo = table.Column<byte[]>(nullable: false),
                    IdOCMensagem = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Anexo_OCMensagem_IdOCMensagem",
                        column: x => x.IdOCMensagem,
                        principalTable: "OCMensagem",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CMSEnderecoLoja",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    ImagemType = table.Column<string>(nullable: true),
                    Imagem = table.Column<byte[]>(nullable: true),
                    Latitute = table.Column<decimal>(nullable: false),
                    Longitude = table.Column<decimal>(nullable: false),
                    ExibirMapa = table.Column<bool>(nullable: false),
                    IdContatoLojaEndereco = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSEnderecoLoja", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CMSEnderecoLoja_ContatoLojaEndereco_IdContatoLojaEndereco",
                        column: x => x.IdContatoLojaEndereco,
                        principalTable: "ContatoLojaEndereco",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acesso_IdModulo",
                table: "Acesso",
                column: "IdModulo");

            migrationBuilder.CreateIndex(
                name: "IX_Acesso_IdPerfil",
                table: "Acesso",
                column: "IdPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_Acesso_PerfilID1",
                table: "Acesso",
                column: "PerfilID1");

            migrationBuilder.CreateIndex(
                name: "IX_Anexo_IdOCMensagem",
                table: "Anexo",
                column: "IdOCMensagem");

            migrationBuilder.CreateIndex(
                name: "IX_Atributo_ProdutoID",
                table: "Atributo",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_IdCliente",
                table: "Carrinho",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_IdLoja",
                table: "Carrinho",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoProduto_IdCarrinho",
                table: "CarrinhoProduto",
                column: "IdCarrinho");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoProduto_IdProduto",
                table: "CarrinhoProduto",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaLoja_IdCategoria",
                table: "CategoriaLoja",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaLoja_IdLoja",
                table: "CategoriaLoja",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaProduto_CategoriaID",
                table: "CategoriaProduto",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaProduto_ProdutoID",
                table: "CategoriaProduto",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_IdProvincia",
                table: "Cidade",
                column: "IdProvincia");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteMensagem_IdClienteProcesso",
                table: "ClienteMensagem",
                column: "IdClienteProcesso");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteProcesso_ClienteID",
                table: "ClienteProcesso",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteProcesso_IdOC",
                table: "ClienteProcesso",
                column: "IdOC");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_CMSCategoriaID",
                table: "CMS",
                column: "CMSCategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_CMSEnderecoLoja_IdContatoLojaEndereco",
                table: "CMSEnderecoLoja",
                column: "IdContatoLojaEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_CMSLoja_IdLoja",
                table: "CMSLoja",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_CMSRedeSocial_IdLoja",
                table: "CMSRedeSocial",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_CMSWhatsApp_IDContatoLojaTelefone",
                table: "CMSWhatsApp",
                column: "IDContatoLojaTelefone");

            migrationBuilder.CreateIndex(
                name: "IX_ContatoLoja_IdLoja",
                table: "ContatoLoja",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_ContatoLojaEmail_IdContatoEmail",
                table: "ContatoLojaEmail",
                column: "IdContatoEmail");

            migrationBuilder.CreateIndex(
                name: "IX_ContatoLojaEmail_IdContatoLoja",
                table: "ContatoLojaEmail",
                column: "IdContatoLoja");

            migrationBuilder.CreateIndex(
                name: "IX_ContatoLojaEndereco_IdContatoLoja",
                table: "ContatoLojaEndereco",
                column: "IdContatoLoja");

            migrationBuilder.CreateIndex(
                name: "IX_ContatoLojaEndereco_IdEndereco",
                table: "ContatoLojaEndereco",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_ContatoLojaRedeSocial_IdContatoLoja",
                table: "ContatoLojaRedeSocial",
                column: "IdContatoLoja");

            migrationBuilder.CreateIndex(
                name: "IX_ContatoLojaRedeSocial_IdContatoRedeSocial",
                table: "ContatoLojaRedeSocial",
                column: "IdContatoRedeSocial");

            migrationBuilder.CreateIndex(
                name: "IX_ContatoLojaTelefone_IdContatoLoja",
                table: "ContatoLojaTelefone",
                column: "IdContatoLoja");

            migrationBuilder.CreateIndex(
                name: "IX_ContatoLojaTelefone_IdContatoTelefone",
                table: "ContatoLojaTelefone",
                column: "IdContatoTelefone");

            migrationBuilder.CreateIndex(
                name: "IX_ContatoTelefone_IdCliente",
                table: "ContatoTelefone",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Empregado_PerfilID",
                table: "Empregado",
                column: "PerfilID");

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoEndereco_EmpregadoID1",
                table: "EmpregadoEndereco",
                column: "EmpregadoID1");

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoEndereco_EnderecoID",
                table: "EmpregadoEndereco",
                column: "EnderecoID");

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoEndereco_IdEmpregado",
                table: "EmpregadoEndereco",
                column: "IdEmpregado");

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoEndereco_IdEndereco",
                table: "EmpregadoEndereco",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoLoja_EmpregadoID1",
                table: "EmpregadoLoja",
                column: "EmpregadoID1");

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoLoja_IdEmpregado",
                table: "EmpregadoLoja",
                column: "IdEmpregado");

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoLoja_IdLoja",
                table: "EmpregadoLoja",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoLoja_LojaID",
                table: "EmpregadoLoja",
                column: "LojaID");

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoOC_EmpregadoID1",
                table: "EmpregadoOC",
                column: "EmpregadoID1");

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoOC_IdEmpregado",
                table: "EmpregadoOC",
                column: "IdEmpregado");

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoOC_IdOC",
                table: "EmpregadoOC",
                column: "IdOC");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdCidade",
                table: "Endereco",
                column: "IdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdCliente",
                table: "Endereco",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Entrega_IdOC",
                table: "Entrega",
                column: "IdOC");

            migrationBuilder.CreateIndex(
                name: "IX_Entrega_IdTransportadora",
                table: "Entrega",
                column: "IdTransportadora");

            migrationBuilder.CreateIndex(
                name: "IX_FabricanteFornecedor_IdFabricante",
                table: "FabricanteFornecedor",
                column: "IdFabricante");

            migrationBuilder.CreateIndex(
                name: "IX_FabricanteFornecedor_IdFornecedor",
                table: "FabricanteFornecedor",
                column: "IdFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_FabricanteLoja_IdFabricante",
                table: "FabricanteLoja",
                column: "IdFabricante");

            migrationBuilder.CreateIndex(
                name: "IX_FabricanteLoja_IdLoja",
                table: "FabricanteLoja",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_FabricanteProduto_IdFabricante",
                table: "FabricanteProduto",
                column: "IdFabricante");

            migrationBuilder.CreateIndex(
                name: "IX_FabricanteProduto_IdProduto",
                table: "FabricanteProduto",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_FaixaDePeso_IdTransportadora",
                table: "FaixaDePeso",
                column: "IdTransportadora");

            migrationBuilder.CreateIndex(
                name: "IX_FaixaDePreco_IdTransportadora",
                table: "FaixaDePreco",
                column: "IdTransportadora");

            migrationBuilder.CreateIndex(
                name: "IX_FornecedorLoja_IdFornecedor",
                table: "FornecedorLoja",
                column: "IdFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_FornecedorLoja_IdLoja",
                table: "FornecedorLoja",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_Loja_CMSID",
                table: "Loja",
                column: "CMSID");

            migrationBuilder.CreateIndex(
                name: "IX_LojaDepartamento_IdDepartamento",
                table: "LojaDepartamento",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_LojaDepartamento_IdLoja",
                table: "LojaDepartamento",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_LojaImagens_IdLoja",
                table: "LojaImagens",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_OC_IdCliente",
                table: "OC",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_OC_IdLoja",
                table: "OC",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_OC_IdMetotoPagamento",
                table: "OC",
                column: "IdMetotoPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_OC_IdOCStatus",
                table: "OC",
                column: "IdOCStatus");

            migrationBuilder.CreateIndex(
                name: "IX_OCDetalhes_IdOC",
                table: "OCDetalhes",
                column: "IdOC");

            migrationBuilder.CreateIndex(
                name: "IX_OCDetalhes_IdProduto",
                table: "OCDetalhes",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_OCFatura_IdOC",
                table: "OCFatura",
                column: "IdOC");

            migrationBuilder.CreateIndex(
                name: "IX_OCMensagem_IdOC",
                table: "OCMensagem",
                column: "IdOC");

            migrationBuilder.CreateIndex(
                name: "IX_OCPagamento_IdOCFatura",
                table: "OCPagamento",
                column: "IdOCFatura");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaPadraoID",
                table: "Produto",
                column: "CategoriaPadraoID");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_LojaPadraoID",
                table: "Produto",
                column: "LojaPadraoID");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCategoria_IdCategoria",
                table: "ProdutoCategoria",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCategoria_IdProduto",
                table: "ProdutoCategoria",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoFornecedor_IdFornecedor",
                table: "ProdutoFornecedor",
                column: "IdFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoFornecedor_IdProduto",
                table: "ProdutoFornecedor",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoGrupo_IdProduto",
                table: "ProdutoGrupo",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoImagem_IdProduto",
                table: "ProdutoImagem",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoLoja_IdLoja",
                table: "ProdutoLoja",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoLoja_IdProduto",
                table: "ProdutoLoja",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoPropriedade_IdProduto",
                table: "ProdutoPropriedade",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoPropriedade_IdPropriedade",
                table: "ProdutoPropriedade",
                column: "IdPropriedade");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoTag_IdProduto",
                table: "ProdutoTag",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoTag_IdTag",
                table: "ProdutoTag",
                column: "IdTag");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoTransportadora_IdProduto",
                table: "ProdutoTransportadora",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoTransportadora_IdTransportadora",
                table: "ProdutoTransportadora",
                column: "IdTransportadora");

            migrationBuilder.CreateIndex(
                name: "IX_PropriedadeValor_IdPropriedade",
                table: "PropriedadeValor",
                column: "IdPropriedade");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_IdPais",
                table: "Provincia",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_TransportadoraEndereco_IdEndereco",
                table: "TransportadoraEndereco",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_TransportadoraEndereco_IdTranportadora",
                table: "TransportadoraEndereco",
                column: "IdTranportadora");

            migrationBuilder.CreateIndex(
                name: "IX_TransportadoraLoja_IdLoja",
                table: "TransportadoraLoja",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_TransportadoraLoja_IdTransportadora",
                table: "TransportadoraLoja",
                column: "IdTransportadora");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acesso");

            migrationBuilder.DropTable(
                name: "Anexo");

            migrationBuilder.DropTable(
                name: "Atributo");

            migrationBuilder.DropTable(
                name: "CarrinhoProduto");

            migrationBuilder.DropTable(
                name: "CategoriaLoja");

            migrationBuilder.DropTable(
                name: "CategoriaProduto");

            migrationBuilder.DropTable(
                name: "ClienteMensagem");

            migrationBuilder.DropTable(
                name: "CMSEnderecoLoja");

            migrationBuilder.DropTable(
                name: "CMSLoja");

            migrationBuilder.DropTable(
                name: "CMSRedeSocial");

            migrationBuilder.DropTable(
                name: "CMSWhatsApp");

            migrationBuilder.DropTable(
                name: "ContatoLojaEmail");

            migrationBuilder.DropTable(
                name: "ContatoLojaRedeSocial");

            migrationBuilder.DropTable(
                name: "EmpregadoEndereco");

            migrationBuilder.DropTable(
                name: "EmpregadoLoja");

            migrationBuilder.DropTable(
                name: "EmpregadoOC");

            migrationBuilder.DropTable(
                name: "Entrega");

            migrationBuilder.DropTable(
                name: "FabricanteFornecedor");

            migrationBuilder.DropTable(
                name: "FabricanteLoja");

            migrationBuilder.DropTable(
                name: "FabricanteProduto");

            migrationBuilder.DropTable(
                name: "FaixaDePeso");

            migrationBuilder.DropTable(
                name: "FaixaDePreco");

            migrationBuilder.DropTable(
                name: "FornecedorLoja");

            migrationBuilder.DropTable(
                name: "LojaDepartamento");

            migrationBuilder.DropTable(
                name: "LojaImagens");

            migrationBuilder.DropTable(
                name: "Moeda");

            migrationBuilder.DropTable(
                name: "OCDetalhes");

            migrationBuilder.DropTable(
                name: "OCPagamento");

            migrationBuilder.DropTable(
                name: "ProdutoCategoria");

            migrationBuilder.DropTable(
                name: "ProdutoFornecedor");

            migrationBuilder.DropTable(
                name: "ProdutoGrupo");

            migrationBuilder.DropTable(
                name: "ProdutoImagem");

            migrationBuilder.DropTable(
                name: "ProdutoLoja");

            migrationBuilder.DropTable(
                name: "ProdutoPropriedade");

            migrationBuilder.DropTable(
                name: "ProdutoTag");

            migrationBuilder.DropTable(
                name: "ProdutoTransportadora");

            migrationBuilder.DropTable(
                name: "PropriedadeValor");

            migrationBuilder.DropTable(
                name: "Regiao");

            migrationBuilder.DropTable(
                name: "SistemaOperacional");

            migrationBuilder.DropTable(
                name: "TransportadoraEndereco");

            migrationBuilder.DropTable(
                name: "TransportadoraLoja");

            migrationBuilder.DropTable(
                name: "WebBrownser");

            migrationBuilder.DropTable(
                name: "Modulo");

            migrationBuilder.DropTable(
                name: "OCMensagem");

            migrationBuilder.DropTable(
                name: "Carrinho");

            migrationBuilder.DropTable(
                name: "ClienteProcesso");

            migrationBuilder.DropTable(
                name: "ContatoLojaEndereco");

            migrationBuilder.DropTable(
                name: "ContatoLojaTelefone");

            migrationBuilder.DropTable(
                name: "ContatoEmail");

            migrationBuilder.DropTable(
                name: "ContatoRedeSocial");

            migrationBuilder.DropTable(
                name: "Empregado");

            migrationBuilder.DropTable(
                name: "Fabricante");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "OCFatura");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Propriedade");

            migrationBuilder.DropTable(
                name: "Transportadora");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "ContatoLoja");

            migrationBuilder.DropTable(
                name: "ContatoTelefone");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "OC");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Loja");

            migrationBuilder.DropTable(
                name: "MetodoPagamento");

            migrationBuilder.DropTable(
                name: "OCStatus");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "CMS");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "CMSCategoria");
        }
    }
}
