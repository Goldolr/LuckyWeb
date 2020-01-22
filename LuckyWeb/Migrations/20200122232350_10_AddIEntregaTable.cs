using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyWeb.Migrations
{
    public partial class _10_AddIEntregaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detalle",
                table: "tbl_Entrega",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "tbl_Entrega",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IDinforme",
                table: "tbl_Entrega",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Entrega_IDinforme",
                table: "tbl_Entrega",
                column: "IDinforme");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Entrega_tbl_Informe_IDinforme",
                table: "tbl_Entrega",
                column: "IDinforme",
                principalTable: "tbl_Informe",
                principalColumn: "IDinforme",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Entrega_tbl_Informe_IDinforme",
                table: "tbl_Entrega");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Entrega_IDinforme",
                table: "tbl_Entrega");

            migrationBuilder.DropColumn(
                name: "Detalle",
                table: "tbl_Entrega");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "tbl_Entrega");

            migrationBuilder.DropColumn(
                name: "IDinforme",
                table: "tbl_Entrega");
        }
    }
}
