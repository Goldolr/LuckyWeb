using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyWeb.Migrations
{
    public partial class _08_AddPruebaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstadoPrueba",
                table: "tbl_Prueba",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IDentrevista",
                table: "tbl_Prueba",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PruebaIDprueba",
                table: "tbl_Entrevista",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Prueba_IDentrevista",
                table: "tbl_Prueba",
                column: "IDentrevista");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Entrevista_PruebaIDprueba",
                table: "tbl_Entrevista",
                column: "PruebaIDprueba");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Entrevista_tbl_Prueba_PruebaIDprueba",
                table: "tbl_Entrevista",
                column: "PruebaIDprueba",
                principalTable: "tbl_Prueba",
                principalColumn: "IDprueba",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Prueba_tbl_Entrevista_IDentrevista",
                table: "tbl_Prueba",
                column: "IDentrevista",
                principalTable: "tbl_Entrevista",
                principalColumn: "IDentrevistas",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Entrevista_tbl_Prueba_PruebaIDprueba",
                table: "tbl_Entrevista");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Prueba_tbl_Entrevista_IDentrevista",
                table: "tbl_Prueba");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Prueba_IDentrevista",
                table: "tbl_Prueba");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Entrevista_PruebaIDprueba",
                table: "tbl_Entrevista");

            migrationBuilder.DropColumn(
                name: "EstadoPrueba",
                table: "tbl_Prueba");

            migrationBuilder.DropColumn(
                name: "IDentrevista",
                table: "tbl_Prueba");

            migrationBuilder.DropColumn(
                name: "PruebaIDprueba",
                table: "tbl_Entrevista");
        }
    }
}
