using Microsoft.EntityFrameworkCore.Migrations;

namespace SCommerce.Infra.Data.Migrations
{
    public partial class ScMigration_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContatoLojaEmail_ContatoEmail_IdContatoEmail",
                table: "ContatoLojaEmail");

            migrationBuilder.DropForeignKey(
                name: "FK_ContatoLojaRedeSocial_ContatoRedeSocial_IdContatoRedeSocial",
                table: "ContatoLojaRedeSocial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContatoRedeSocial",
                table: "ContatoRedeSocial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContatoEmail",
                table: "ContatoEmail");

            migrationBuilder.RenameTable(
                name: "ContatoRedeSocial",
                newName: "ContatoRedeSocials");

            migrationBuilder.RenameTable(
                name: "ContatoEmail",
                newName: "ContatoEmails");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "ContatoTelefone",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContatoRedeSocials",
                table: "ContatoRedeSocials",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContatoEmails",
                table: "ContatoEmails",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContatoLojaEmail_ContatoEmails_IdContatoEmail",
                table: "ContatoLojaEmail",
                column: "IdContatoEmail",
                principalTable: "ContatoEmails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContatoLojaRedeSocial_ContatoRedeSocials_IdContatoRedeSocial",
                table: "ContatoLojaRedeSocial",
                column: "IdContatoRedeSocial",
                principalTable: "ContatoRedeSocials",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContatoLojaEmail_ContatoEmails_IdContatoEmail",
                table: "ContatoLojaEmail");

            migrationBuilder.DropForeignKey(
                name: "FK_ContatoLojaRedeSocial_ContatoRedeSocials_IdContatoRedeSocial",
                table: "ContatoLojaRedeSocial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContatoRedeSocials",
                table: "ContatoRedeSocials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContatoEmails",
                table: "ContatoEmails");

            migrationBuilder.RenameTable(
                name: "ContatoRedeSocials",
                newName: "ContatoRedeSocial");

            migrationBuilder.RenameTable(
                name: "ContatoEmails",
                newName: "ContatoEmail");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "ContatoTelefone",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContatoRedeSocial",
                table: "ContatoRedeSocial",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContatoEmail",
                table: "ContatoEmail",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContatoLojaEmail_ContatoEmail_IdContatoEmail",
                table: "ContatoLojaEmail",
                column: "IdContatoEmail",
                principalTable: "ContatoEmail",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContatoLojaRedeSocial_ContatoRedeSocial_IdContatoRedeSocial",
                table: "ContatoLojaRedeSocial",
                column: "IdContatoRedeSocial",
                principalTable: "ContatoRedeSocial",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
