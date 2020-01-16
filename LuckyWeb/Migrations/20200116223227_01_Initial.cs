using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LuckyWeb.Migrations
{
    public partial class _01_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Agenda",
                columns: table => new
                {
                    IDagenda = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Agenda", x => x.IDagenda);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Entrega",
                columns: table => new
                {
                    IDentrega = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Entrega", x => x.IDentrega);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Entrevista",
                columns: table => new
                {
                    IDentrevistas = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Entrevista", x => x.IDentrevistas);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Informe",
                columns: table => new
                {
                    IDinforme = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Informe", x => x.IDinforme);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Mascota",
                columns: table => new
                {
                    IdMascota = table.Column<Guid>(nullable: false),
                    NombreMascota = table.Column<string>(nullable: true),
                    EdadMascota = table.Column<int>(nullable: false),
                    Raza = table.Column<string>(nullable: true),
                    Esterilizado = table.Column<string>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Mascota", x => x.IdMascota);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Pregunta",
                columns: table => new
                {
                    IDpreguntas = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Pregunta1 = table.Column<string>(nullable: true),
                    Pregunta2 = table.Column<string>(nullable: true),
                    Pregunta3 = table.Column<string>(nullable: true),
                    Pregunta4 = table.Column<string>(nullable: true),
                    Pregunta5 = table.Column<string>(nullable: true),
                    Pregunta6 = table.Column<string>(nullable: true),
                    Pregunta7 = table.Column<string>(nullable: true),
                    Pregunta8 = table.Column<string>(nullable: true),
                    Pregunta9 = table.Column<string>(nullable: true),
                    Pregunta10 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Pregunta", x => x.IDpreguntas);
                });

            migrationBuilder.CreateTable(
                name: "tbl_User",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Cedula = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Contrasenia = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_User", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "tbl_FormularioEncuesta",
                columns: table => new
                {
                    IDformularioEncuesta = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IDuser = table.Column<Guid>(nullable: false),
                    IDmascota = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FormularioEncuesta", x => x.IDformularioEncuesta);
                    table.ForeignKey(
                        name: "FK_tbl_FormularioEncuesta_tbl_Mascota_IDmascota",
                        column: x => x.IDmascota,
                        principalTable: "tbl_Mascota",
                        principalColumn: "IdMascota",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_FormularioEncuesta_tbl_User_IDuser",
                        column: x => x.IDuser,
                        principalTable: "tbl_User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FormularioEncuesta_IDmascota",
                table: "tbl_FormularioEncuesta",
                column: "IDmascota");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FormularioEncuesta_IDuser",
                table: "tbl_FormularioEncuesta",
                column: "IDuser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Agenda");

            migrationBuilder.DropTable(
                name: "tbl_Entrega");

            migrationBuilder.DropTable(
                name: "tbl_Entrevista");

            migrationBuilder.DropTable(
                name: "tbl_FormularioEncuesta");

            migrationBuilder.DropTable(
                name: "tbl_Informe");

            migrationBuilder.DropTable(
                name: "tbl_Pregunta");

            migrationBuilder.DropTable(
                name: "tbl_Mascota");

            migrationBuilder.DropTable(
                name: "tbl_User");
        }
    }
}
