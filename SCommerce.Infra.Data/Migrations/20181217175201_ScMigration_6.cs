using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCommerce.Infra.Data.Migrations
{
    public partial class ScMigration_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoCategoria_Produto_IdProduto",
                table: "ProdutoCategoria");

            migrationBuilder.DropIndex(
                name: "IX_ProdutoCategoria_IdProduto",
                table: "ProdutoCategoria");

            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoID",
                table: "ProdutoCategoria",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCategoria_ProdutoID",
                table: "ProdutoCategoria",
                column: "ProdutoID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoCategoria_Produto_ProdutoID",
                table: "ProdutoCategoria",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoCategoria_Produto_ProdutoID",
                table: "ProdutoCategoria");

            migrationBuilder.DropIndex(
                name: "IX_ProdutoCategoria_ProdutoID",
                table: "ProdutoCategoria");

            migrationBuilder.DropColumn(
                name: "ProdutoID",
                table: "ProdutoCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCategoria_IdProduto",
                table: "ProdutoCategoria",
                column: "IdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoCategoria_Produto_IdProduto",
                table: "ProdutoCategoria",
                column: "IdProduto",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
