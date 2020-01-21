using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyWeb.Migrations
{
    public partial class _04_FechaAgenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAgenda",
                table: "tbl_Agenda",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaAgenda",
                table: "tbl_Agenda");
        }
    }
}
