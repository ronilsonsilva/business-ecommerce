using Microsoft.EntityFrameworkCore.Migrations;

namespace SCommerce.Infra.Data.Migrations
{
    public partial class ScMigration_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Posicao",
                table: "OCMensagem",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Posicao",
                table: "OCMensagem");
        }
    }
}
