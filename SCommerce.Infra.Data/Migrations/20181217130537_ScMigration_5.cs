using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCommerce.Infra.Data.Migrations
{
    public partial class ScMigration_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContatoTelefone_Cliente_IdCliente",
                table: "ContatoTelefone");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdCliente",
                table: "ContatoTelefone",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_ContatoTelefone_Cliente_IdCliente",
                table: "ContatoTelefone",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContatoTelefone_Cliente_IdCliente",
                table: "ContatoTelefone");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdCliente",
                table: "ContatoTelefone",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContatoTelefone_Cliente_IdCliente",
                table: "ContatoTelefone",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
