using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyWeb.Migrations
{
    public partial class _04_AddFieldImagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "tbl_Mascota",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "tbl_Mascota");
        }
    }
}
