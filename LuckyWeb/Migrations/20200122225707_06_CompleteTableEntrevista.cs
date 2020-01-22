using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyWeb.Migrations
{
    public partial class _06_CompleteTableEntrevista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstadoEntrevista",
                table: "tbl_Entrevista",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IDagenda",
                table: "tbl_Entrevista",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "IDuser",
                table: "tbl_Entrevista",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "EntrevistaIDentrevistas",
                table: "tbl_Agenda",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Entrevista_IDagenda",
                table: "tbl_Entrevista",
                column: "IDagenda");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Entrevista_IDuser",
                table: "tbl_Entrevista",
                column: "IDuser");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Agenda_EntrevistaIDentrevistas",
                table: "tbl_Agenda",
                column: "EntrevistaIDentrevistas");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Agenda_tbl_Entrevista_EntrevistaIDentrevistas",
                table: "tbl_Agenda",
                column: "EntrevistaIDentrevistas",
                principalTable: "tbl_Entrevista",
                principalColumn: "IDentrevistas",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Entrevista_tbl_Agenda_IDagenda",
                table: "tbl_Entrevista",
                column: "IDagenda",
                principalTable: "tbl_Agenda",
                principalColumn: "IDagenda",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Entrevista_tbl_User_IDuser",
                table: "tbl_Entrevista",
                column: "IDuser",
                principalTable: "tbl_User",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Agenda_tbl_Entrevista_EntrevistaIDentrevistas",
                table: "tbl_Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Entrevista_tbl_Agenda_IDagenda",
                table: "tbl_Entrevista");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Entrevista_tbl_User_IDuser",
                table: "tbl_Entrevista");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Entrevista_IDagenda",
                table: "tbl_Entrevista");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Entrevista_IDuser",
                table: "tbl_Entrevista");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Agenda_EntrevistaIDentrevistas",
                table: "tbl_Agenda");

            migrationBuilder.DropColumn(
                name: "EstadoEntrevista",
                table: "tbl_Entrevista");

            migrationBuilder.DropColumn(
                name: "IDagenda",
                table: "tbl_Entrevista");

            migrationBuilder.DropColumn(
                name: "IDuser",
                table: "tbl_Entrevista");

            migrationBuilder.DropColumn(
                name: "EntrevistaIDentrevistas",
                table: "tbl_Agenda");
        }
    }
}
