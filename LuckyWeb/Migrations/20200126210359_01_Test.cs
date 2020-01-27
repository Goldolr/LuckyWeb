using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LuckyWeb.Migrations
{
    public partial class _01_Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Esterilizado",
                columns: table => new
                {
                    IDesterilizad = table.Column<Guid>(nullable: false),
                    EstadoEsterilizado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Esterilizado", x => x.IDesterilizad);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Raza",
                columns: table => new
                {
                    IDraza = table.Column<Guid>(nullable: false),
                    RazaMascota = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Raza", x => x.IDraza);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Respuesta1",
                columns: table => new
                {
                    IDrespuesta1 = table.Column<Guid>(nullable: false),
                    Respuesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Respuesta1", x => x.IDrespuesta1);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Respuesta10",
                columns: table => new
                {
                    IDrespuesta10 = table.Column<Guid>(nullable: false),
                    Respuesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Respuesta10", x => x.IDrespuesta10);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Respuesta2",
                columns: table => new
                {
                    IDrespuesta2 = table.Column<Guid>(nullable: false),
                    Respuesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Respuesta2", x => x.IDrespuesta2);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Respuesta3",
                columns: table => new
                {
                    IDrespuesta3 = table.Column<Guid>(nullable: false),
                    Respuesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Respuesta3", x => x.IDrespuesta3);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Respuesta4",
                columns: table => new
                {
                    IDrespuesta4 = table.Column<Guid>(nullable: false),
                    Respuesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Respuesta4", x => x.IDrespuesta4);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Respuesta5",
                columns: table => new
                {
                    IDrespuesta5 = table.Column<Guid>(nullable: false),
                    Respuesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Respuesta5", x => x.IDrespuesta5);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Respuesta6",
                columns: table => new
                {
                    IDrespuesta6 = table.Column<Guid>(nullable: false),
                    Respuesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Respuesta6", x => x.IDrespuesta6);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Respuesta7",
                columns: table => new
                {
                    IDrespuesta7 = table.Column<Guid>(nullable: false),
                    Respuesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Respuesta7", x => x.IDrespuesta7);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Respuesta8",
                columns: table => new
                {
                    IDrespuesta8 = table.Column<Guid>(nullable: false),
                    Respuesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Respuesta8", x => x.IDrespuesta8);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Respuesta9",
                columns: table => new
                {
                    IDrespuesta9 = table.Column<Guid>(nullable: false),
                    Respuesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Respuesta9", x => x.IDrespuesta9);
                });

            migrationBuilder.CreateTable(
                name: "tbl_User",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Cedula = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Contrasenia = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_User", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Mascota",
                columns: table => new
                {
                    IdMascota = table.Column<Guid>(nullable: false),
                    NombreMascota = table.Column<string>(nullable: false),
                    EdadMascota = table.Column<int>(nullable: false),
                    IDraza = table.Column<Guid>(nullable: false),
                    IDesterilizado = table.Column<Guid>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Mascota", x => x.IdMascota);
                    table.ForeignKey(
                        name: "FK_tbl_Mascota_tbl_Esterilizado_IDesterilizado",
                        column: x => x.IDesterilizado,
                        principalTable: "tbl_Esterilizado",
                        principalColumn: "IDesterilizad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Mascota_tbl_Esterilizado_IDraza",
                        column: x => x.IDraza,
                        principalTable: "tbl_Esterilizado",
                        principalColumn: "IDesterilizad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Pregunta",
                columns: table => new
                {
                    IDpreguntas = table.Column<Guid>(nullable: false),
                    EstadoPreguntas = table.Column<bool>(nullable: false),
                    IDrespuesta1 = table.Column<Guid>(nullable: false),
                    IDrespuesta2 = table.Column<Guid>(nullable: false),
                    IDrespuesta3 = table.Column<Guid>(nullable: false),
                    IDrespuesta4 = table.Column<Guid>(nullable: false),
                    IDrespuesta5 = table.Column<Guid>(nullable: false),
                    IDrespuesta6 = table.Column<Guid>(nullable: false),
                    IDrespuesta7 = table.Column<Guid>(nullable: false),
                    IDrespuesta8 = table.Column<Guid>(nullable: false),
                    IDrespuesta9 = table.Column<Guid>(nullable: false),
                    IDrespuesta10 = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Pregunta", x => x.IDpreguntas);
                    table.ForeignKey(
                        name: "FK_tbl_Pregunta_tbl_Respuesta1_IDrespuesta1",
                        column: x => x.IDrespuesta1,
                        principalTable: "tbl_Respuesta1",
                        principalColumn: "IDrespuesta1",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Pregunta_tbl_Respuesta10_IDrespuesta10",
                        column: x => x.IDrespuesta10,
                        principalTable: "tbl_Respuesta10",
                        principalColumn: "IDrespuesta10",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Pregunta_tbl_Respuesta2_IDrespuesta2",
                        column: x => x.IDrespuesta2,
                        principalTable: "tbl_Respuesta2",
                        principalColumn: "IDrespuesta2",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Pregunta_tbl_Respuesta3_IDrespuesta3",
                        column: x => x.IDrespuesta3,
                        principalTable: "tbl_Respuesta3",
                        principalColumn: "IDrespuesta3",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Pregunta_tbl_Respuesta4_IDrespuesta4",
                        column: x => x.IDrespuesta4,
                        principalTable: "tbl_Respuesta4",
                        principalColumn: "IDrespuesta4",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Pregunta_tbl_Respuesta5_IDrespuesta5",
                        column: x => x.IDrespuesta5,
                        principalTable: "tbl_Respuesta5",
                        principalColumn: "IDrespuesta5",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Pregunta_tbl_Respuesta6_IDrespuesta6",
                        column: x => x.IDrespuesta6,
                        principalTable: "tbl_Respuesta6",
                        principalColumn: "IDrespuesta6",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Pregunta_tbl_Respuesta7_IDrespuesta7",
                        column: x => x.IDrespuesta7,
                        principalTable: "tbl_Respuesta7",
                        principalColumn: "IDrespuesta7",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Pregunta_tbl_Respuesta8_IDrespuesta8",
                        column: x => x.IDrespuesta8,
                        principalTable: "tbl_Respuesta8",
                        principalColumn: "IDrespuesta8",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Pregunta_tbl_Respuesta9_IDrespuesta9",
                        column: x => x.IDrespuesta9,
                        principalTable: "tbl_Respuesta9",
                        principalColumn: "IDrespuesta9",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_FormularioEncuesta",
                columns: table => new
                {
                    IDformularioEncuesta = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IDuser = table.Column<Guid>(nullable: false),
                    IDmascota = table.Column<Guid>(nullable: false),
                    IDpreguntas = table.Column<Guid>(nullable: false)
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
                        name: "FK_tbl_FormularioEncuesta_tbl_Pregunta_IDpreguntas",
                        column: x => x.IDpreguntas,
                        principalTable: "tbl_Pregunta",
                        principalColumn: "IDpreguntas",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_FormularioEncuesta_tbl_User_IDuser",
                        column: x => x.IDuser,
                        principalTable: "tbl_User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Entrevista",
                columns: table => new
                {
                    IDentrevistas = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IDagenda = table.Column<int>(nullable: false),
                    IDuser = table.Column<Guid>(nullable: false),
                    EstadoEntrevista = table.Column<bool>(nullable: false),
                    PruebaIDprueba = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Entrevista", x => x.IDentrevistas);
                    table.ForeignKey(
                        name: "FK_tbl_Entrevista_tbl_User_IDuser",
                        column: x => x.IDuser,
                        principalTable: "tbl_User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Agenda",
                columns: table => new
                {
                    IDagenda = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FechaAgenda = table.Column<DateTime>(nullable: false),
                    IDuser = table.Column<Guid>(nullable: false),
                    EntrevistaIDentrevistas = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Agenda", x => x.IDagenda);
                    table.ForeignKey(
                        name: "FK_tbl_Agenda_tbl_Entrevista_EntrevistaIDentrevistas",
                        column: x => x.EntrevistaIDentrevistas,
                        principalTable: "tbl_Entrevista",
                        principalColumn: "IDentrevistas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Agenda_tbl_User_IDuser",
                        column: x => x.IDuser,
                        principalTable: "tbl_User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Prueba",
                columns: table => new
                {
                    IDprueba = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EstadoPrueba = table.Column<bool>(nullable: false),
                    IDentrevista = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Prueba", x => x.IDprueba);
                    table.ForeignKey(
                        name: "FK_tbl_Prueba_tbl_Entrevista_IDentrevista",
                        column: x => x.IDentrevista,
                        principalTable: "tbl_Entrevista",
                        principalColumn: "IDentrevistas",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Informe",
                columns: table => new
                {
                    IDinforme = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Detalle = table.Column<string>(nullable: true),
                    IDprueba = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Informe", x => x.IDinforme);
                    table.ForeignKey(
                        name: "FK_tbl_Informe_tbl_Prueba_IDprueba",
                        column: x => x.IDprueba,
                        principalTable: "tbl_Prueba",
                        principalColumn: "IDprueba",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Entrega",
                columns: table => new
                {
                    IDentrega = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Estado = table.Column<bool>(nullable: false),
                    Detalle = table.Column<string>(nullable: false),
                    IDinforme = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Entrega", x => x.IDentrega);
                    table.ForeignKey(
                        name: "FK_tbl_Entrega_tbl_Informe_IDinforme",
                        column: x => x.IDinforme,
                        principalTable: "tbl_Informe",
                        principalColumn: "IDinforme",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Agenda_EntrevistaIDentrevistas",
                table: "tbl_Agenda",
                column: "EntrevistaIDentrevistas");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Agenda_IDuser",
                table: "tbl_Agenda",
                column: "IDuser");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Entrega_IDinforme",
                table: "tbl_Entrega",
                column: "IDinforme");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Entrevista_IDagenda",
                table: "tbl_Entrevista",
                column: "IDagenda");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Entrevista_IDuser",
                table: "tbl_Entrevista",
                column: "IDuser");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Entrevista_PruebaIDprueba",
                table: "tbl_Entrevista",
                column: "PruebaIDprueba");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FormularioEncuesta_IDmascota",
                table: "tbl_FormularioEncuesta",
                column: "IDmascota");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FormularioEncuesta_IDpreguntas",
                table: "tbl_FormularioEncuesta",
                column: "IDpreguntas");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FormularioEncuesta_IDuser",
                table: "tbl_FormularioEncuesta",
                column: "IDuser");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Informe_IDprueba",
                table: "tbl_Informe",
                column: "IDprueba");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Mascota_IDesterilizado",
                table: "tbl_Mascota",
                column: "IDesterilizado");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Mascota_IDraza",
                table: "tbl_Mascota",
                column: "IDraza");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pregunta_IDrespuesta1",
                table: "tbl_Pregunta",
                column: "IDrespuesta1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pregunta_IDrespuesta10",
                table: "tbl_Pregunta",
                column: "IDrespuesta10");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pregunta_IDrespuesta2",
                table: "tbl_Pregunta",
                column: "IDrespuesta2");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pregunta_IDrespuesta3",
                table: "tbl_Pregunta",
                column: "IDrespuesta3");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pregunta_IDrespuesta4",
                table: "tbl_Pregunta",
                column: "IDrespuesta4");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pregunta_IDrespuesta5",
                table: "tbl_Pregunta",
                column: "IDrespuesta5");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pregunta_IDrespuesta6",
                table: "tbl_Pregunta",
                column: "IDrespuesta6");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pregunta_IDrespuesta7",
                table: "tbl_Pregunta",
                column: "IDrespuesta7");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pregunta_IDrespuesta8",
                table: "tbl_Pregunta",
                column: "IDrespuesta8");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pregunta_IDrespuesta9",
                table: "tbl_Pregunta",
                column: "IDrespuesta9");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Prueba_IDentrevista",
                table: "tbl_Prueba",
                column: "IDentrevista");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Entrevista_tbl_Agenda_IDagenda",
                table: "tbl_Entrevista",
                column: "IDagenda",
                principalTable: "tbl_Agenda",
                principalColumn: "IDagenda",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Entrevista_tbl_Prueba_PruebaIDprueba",
                table: "tbl_Entrevista",
                column: "PruebaIDprueba",
                principalTable: "tbl_Prueba",
                principalColumn: "IDprueba",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Agenda_tbl_Entrevista_EntrevistaIDentrevistas",
                table: "tbl_Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Prueba_tbl_Entrevista_IDentrevista",
                table: "tbl_Prueba");

            migrationBuilder.DropTable(
                name: "tbl_Entrega");

            migrationBuilder.DropTable(
                name: "tbl_FormularioEncuesta");

            migrationBuilder.DropTable(
                name: "tbl_Raza");

            migrationBuilder.DropTable(
                name: "tbl_Informe");

            migrationBuilder.DropTable(
                name: "tbl_Mascota");

            migrationBuilder.DropTable(
                name: "tbl_Pregunta");

            migrationBuilder.DropTable(
                name: "tbl_Esterilizado");

            migrationBuilder.DropTable(
                name: "tbl_Respuesta1");

            migrationBuilder.DropTable(
                name: "tbl_Respuesta10");

            migrationBuilder.DropTable(
                name: "tbl_Respuesta2");

            migrationBuilder.DropTable(
                name: "tbl_Respuesta3");

            migrationBuilder.DropTable(
                name: "tbl_Respuesta4");

            migrationBuilder.DropTable(
                name: "tbl_Respuesta5");

            migrationBuilder.DropTable(
                name: "tbl_Respuesta6");

            migrationBuilder.DropTable(
                name: "tbl_Respuesta7");

            migrationBuilder.DropTable(
                name: "tbl_Respuesta8");

            migrationBuilder.DropTable(
                name: "tbl_Respuesta9");

            migrationBuilder.DropTable(
                name: "tbl_Entrevista");

            migrationBuilder.DropTable(
                name: "tbl_Agenda");

            migrationBuilder.DropTable(
                name: "tbl_Prueba");

            migrationBuilder.DropTable(
                name: "tbl_User");
        }
    }
}
