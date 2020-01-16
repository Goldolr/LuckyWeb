﻿// <auto-generated />
using System;
using LuckyWeb.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LuckyWeb.Migrations
{
    [DbContext(typeof(MascotasContext))]
    [Migration("20200116223227_01_Initial")]
    partial class _01_Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("LuckyWeb.Models.Agenda", b =>
                {
                    b.Property<int>("IDagenda")
                        .ValueGeneratedOnAdd();

                    b.HasKey("IDagenda");

                    b.ToTable("tbl_Agenda");
                });

            modelBuilder.Entity("LuckyWeb.Models.Entrega", b =>
                {
                    b.Property<int>("IDentrega")
                        .ValueGeneratedOnAdd();

                    b.HasKey("IDentrega");

                    b.ToTable("tbl_Entrega");
                });

            modelBuilder.Entity("LuckyWeb.Models.Entrevista", b =>
                {
                    b.Property<int>("IDentrevistas")
                        .ValueGeneratedOnAdd();

                    b.HasKey("IDentrevistas");

                    b.ToTable("tbl_Entrevista");
                });

            modelBuilder.Entity("LuckyWeb.Models.FormularioEncuesta", b =>
                {
                    b.Property<int>("IDformularioEncuesta")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("IDmascota");

                    b.Property<Guid>("IDuser");

                    b.HasKey("IDformularioEncuesta");

                    b.HasIndex("IDmascota");

                    b.HasIndex("IDuser");

                    b.ToTable("tbl_FormularioEncuesta");
                });

            modelBuilder.Entity("LuckyWeb.Models.Informe", b =>
                {
                    b.Property<int>("IDinforme")
                        .ValueGeneratedOnAdd();

                    b.HasKey("IDinforme");

                    b.ToTable("tbl_Informe");
                });

            modelBuilder.Entity("LuckyWeb.Models.Mascota", b =>
                {
                    b.Property<Guid>("IdMascota")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EdadMascota");

                    b.Property<bool>("Estado");

                    b.Property<string>("Esterilizado")
                        .IsRequired();

                    b.Property<string>("NombreMascota");

                    b.Property<string>("Raza");

                    b.HasKey("IdMascota");

                    b.ToTable("tbl_Mascota");
                });

            modelBuilder.Entity("LuckyWeb.Models.Pregunta", b =>
                {
                    b.Property<int>("IDpreguntas")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Pregunta1");

                    b.Property<string>("Pregunta10");

                    b.Property<string>("Pregunta2");

                    b.Property<string>("Pregunta3");

                    b.Property<string>("Pregunta4");

                    b.Property<string>("Pregunta5");

                    b.Property<string>("Pregunta6");

                    b.Property<string>("Pregunta7");

                    b.Property<string>("Pregunta8");

                    b.Property<string>("Pregunta9");

                    b.HasKey("IDpreguntas");

                    b.ToTable("tbl_Pregunta");
                });

            modelBuilder.Entity("LuckyWeb.Models.User", b =>
                {
                    b.Property<Guid>("IdUser")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Cedula");

                    b.Property<string>("Contrasenia");

                    b.Property<string>("Correo");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nombre");

                    b.HasKey("IdUser");

                    b.ToTable("tbl_User");
                });

            modelBuilder.Entity("LuckyWeb.Models.FormularioEncuesta", b =>
                {
                    b.HasOne("LuckyWeb.Models.Mascota", "FK_MascotaFormularioEncuesta")
                        .WithMany("FormularioEncuestas")
                        .HasForeignKey("IDmascota")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LuckyWeb.Models.User", "FK_UserFormularioEncuesta")
                        .WithMany("FormularioEncuestas")
                        .HasForeignKey("IDuser")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
