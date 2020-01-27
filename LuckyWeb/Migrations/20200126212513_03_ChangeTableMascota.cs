using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyWeb.Migrations
{
    public partial class _03_ChangeTableMascota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Mascota_tbl_Esterilizado_IDraza",
                table: "tbl_Mascota");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "tbl_Mascota");

            migrationBuilder.AddColumn<Guid>(
                name: "IDestadoMascota",
                table: "tbl_Mascota",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Mascota_IDestadoMascota",
                table: "tbl_Mascota",
                column: "IDestadoMascota");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Mascota_tbl_EstadoMascota_IDestadoMascota",
                table: "tbl_Mascota",
                column: "IDestadoMascota",
                principalTable: "tbl_EstadoMascota",
                principalColumn: "IDestadoMascota",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Mascota_tbl_Raza_IDraza",
                table: "tbl_Mascota",
                column: "IDraza",
                principalTable: "tbl_Raza",
                principalColumn: "IDraza",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Mascota_tbl_EstadoMascota_IDestadoMascota",
                table: "tbl_Mascota");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Mascota_tbl_Raza_IDraza",
                table: "tbl_Mascota");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Mascota_IDestadoMascota",
                table: "tbl_Mascota");

            migrationBuilder.DropColumn(
                name: "IDestadoMascota",
                table: "tbl_Mascota");

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "tbl_Mascota",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Mascota_tbl_Esterilizado_IDraza",
                table: "tbl_Mascota",
                column: "IDraza",
                principalTable: "tbl_Esterilizado",
                principalColumn: "IDesterilizad",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
