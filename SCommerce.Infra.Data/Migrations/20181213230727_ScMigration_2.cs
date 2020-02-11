using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCommerce.Infra.Data.Migrations
{
    public partial class ScMigration_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CMSSlidePrincipal",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ArquivoType = table.Column<string>(nullable: true),
                    ArquivoImage = table.Column<byte[]>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFinal = table.Column<DateTime>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false),
                    TituloPrincipal = table.Column<string>(nullable: true),
                    Subtitulo = table.Column<string>(nullable: true),
                    Produto = table.Column<bool>(nullable: false),
                    Categoria = table.Column<bool>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    IdCategoria = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSSlidePrincipal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoPromocao",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    PercentualDesconto = table.Column<decimal>(nullable: false),
                    ValorDesconto = table.Column<decimal>(nullable: false),
                    ValorAnterior = table.Column<decimal>(nullable: false),
                    ValorComDesconto = table.Column<decimal>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Atualizado = table.Column<DateTime>(nullable: false),
                    DataInicioPromocao = table.Column<DateTime>(nullable: false),
                    DataFimPromocao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoPromocao", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProdutoPromocao_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoPromocao_IdProduto",
                table: "ProdutoPromocao",
                column: "IdProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CMSSlidePrincipal");

            migrationBuilder.DropTable(
                name: "ProdutoPromocao");
        }
    }
}
