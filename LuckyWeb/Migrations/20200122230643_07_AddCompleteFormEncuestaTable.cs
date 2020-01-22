using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyWeb.Migrations
{
    public partial class _07_AddCompleteFormEncuestaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDpregunta",
                table: "tbl_FormularioEncuesta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FormularioEncuesta_IDpregunta",
                table: "tbl_FormularioEncuesta",
                column: "IDpregunta");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_FormularioEncuesta_tbl_Pregunta_IDpregunta",
                table: "tbl_FormularioEncuesta",
                column: "IDpregunta",
                principalTable: "tbl_Pregunta",
                principalColumn: "IDpreguntas",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_FormularioEncuesta_tbl_Pregunta_IDpregunta",
                table: "tbl_FormularioEncuesta");

            migrationBuilder.DropIndex(
                name: "IX_tbl_FormularioEncuesta_IDpregunta",
                table: "tbl_FormularioEncuesta");

            migrationBuilder.DropColumn(
                name: "IDpregunta",
                table: "tbl_FormularioEncuesta");
        }
    }
}
