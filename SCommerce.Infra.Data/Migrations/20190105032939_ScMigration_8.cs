using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCommerce.Infra.Data.Migrations
{
    public partial class ScMigration_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OC_Cliente_IdCliente",
                table: "OC");

            migrationBuilder.DropForeignKey(
                name: "FK_OC_Loja_IdLoja",
                table: "OC");

            migrationBuilder.DropForeignKey(
                name: "FK_OC_MetodoPagamento_IdMetotoPagamento",
                table: "OC");

            migrationBuilder.DropForeignKey(
                name: "FK_OC_OCStatus_IdOCStatus",
                table: "OC");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdOCStatus",
                table: "OC",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "IdMetotoPagamento",
                table: "OC",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "IdLoja",
                table: "OC",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "IdCliente",
                table: "OC",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_OC_Cliente_IdCliente",
                table: "OC",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OC_Loja_IdLoja",
                table: "OC",
                column: "IdLoja",
                principalTable: "Loja",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OC_MetodoPagamento_IdMetotoPagamento",
                table: "OC",
                column: "IdMetotoPagamento",
                principalTable: "MetodoPagamento",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OC_OCStatus_IdOCStatus",
                table: "OC",
                column: "IdOCStatus",
                principalTable: "OCStatus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OC_Cliente_IdCliente",
                table: "OC");

            migrationBuilder.DropForeignKey(
                name: "FK_OC_Loja_IdLoja",
                table: "OC");

            migrationBuilder.DropForeignKey(
                name: "FK_OC_MetodoPagamento_IdMetotoPagamento",
                table: "OC");

            migrationBuilder.DropForeignKey(
                name: "FK_OC_OCStatus_IdOCStatus",
                table: "OC");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdOCStatus",
                table: "OC",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdMetotoPagamento",
                table: "OC",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdLoja",
                table: "OC",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdCliente",
                table: "OC",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OC_Cliente_IdCliente",
                table: "OC",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OC_Loja_IdLoja",
                table: "OC",
                column: "IdLoja",
                principalTable: "Loja",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OC_MetodoPagamento_IdMetotoPagamento",
                table: "OC",
                column: "IdMetotoPagamento",
                principalTable: "MetodoPagamento",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OC_OCStatus_IdOCStatus",
                table: "OC",
                column: "IdOCStatus",
                principalTable: "OCStatus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
