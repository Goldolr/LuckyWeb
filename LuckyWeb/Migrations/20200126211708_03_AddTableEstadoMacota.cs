using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyWeb.Migrations
{
    public partial class _03_AddTableEstadoMacota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_EstadoMascota",
                columns: table => new
                {
                    IDestadoMascota = table.Column<Guid>(nullable: false),
                    Aprobacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EstadoMascota", x => x.IDestadoMascota);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_EstadoMascota");
        }
    }
}
