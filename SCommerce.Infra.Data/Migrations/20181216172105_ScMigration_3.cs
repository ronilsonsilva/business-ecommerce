using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCommerce.Infra.Data.Migrations
{
    public partial class ScMigration_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Cliente_IdCliente",
                table: "Endereco");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdCliente",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Cliente_IdCliente",
                table: "Endereco",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Cliente_IdCliente",
                table: "Endereco");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdCliente",
                table: "Endereco",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Cliente_IdCliente",
                table: "Endereco",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
