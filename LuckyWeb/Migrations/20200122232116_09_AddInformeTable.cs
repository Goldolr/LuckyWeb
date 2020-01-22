using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyWeb.Migrations
{
    public partial class _09_AddInformeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detalle",
                table: "tbl_Informe",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IDprueba",
                table: "tbl_Informe",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Informe_IDprueba",
                table: "tbl_Informe",
                column: "IDprueba");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Informe_tbl_Prueba_IDprueba",
                table: "tbl_Informe",
                column: "IDprueba",
                principalTable: "tbl_Prueba",
                principalColumn: "IDprueba",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Informe_tbl_Prueba_IDprueba",
                table: "tbl_Informe");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Informe_IDprueba",
                table: "tbl_Informe");

            migrationBuilder.DropColumn(
                name: "Detalle",
                table: "tbl_Informe");

            migrationBuilder.DropColumn(
                name: "IDprueba",
                table: "tbl_Informe");
        }
    }
}
