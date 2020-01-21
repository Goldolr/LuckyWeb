using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyWeb.Migrations
{
    public partial class _05_Add_FK_UserAgenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IDuser",
                table: "tbl_Agenda",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Agenda_IDuser",
                table: "tbl_Agenda",
                column: "IDuser");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Agenda_tbl_User_IDuser",
                table: "tbl_Agenda",
                column: "IDuser",
                principalTable: "tbl_User",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Agenda_tbl_User_IDuser",
                table: "tbl_Agenda");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Agenda_IDuser",
                table: "tbl_Agenda");

            migrationBuilder.DropColumn(
                name: "IDuser",
                table: "tbl_Agenda");
        }
    }
}
