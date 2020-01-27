using LuckyWeb.Models;
using LuckyWeb.Models.Respuestas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyWeb.Context
{
    public class MascotasContext: DbContext
    {
        public MascotasContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Entrega> Entregas { get; set; }
        public DbSet<Entrevista> Entrevistas { get; set; }
        public DbSet<FormularioEncuesta> FormularioEncuestas { get; set; }
        public DbSet<Informe> Informes { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<Prueba> Prueba { get; set; }
        public DbSet<Esterilizado> Esterilizados { get; set; }
        public DbSet<Raza> Razas { get; set; }
        public DbSet<Respuesta1> Respuestas1 { get; set; }
        public DbSet<Respuesta2> Respuestas2 { get; set; }
        public DbSet<Respuesta3> Respuestas3 { get; set; }
        public DbSet<Respuesta4> Respuestas4 { get; set; }
        public DbSet<Respuesta5> Respuestas5 { get; set; }
        public DbSet<Respuesta6> Respuestas6 { get; set; }
        public DbSet<Respuesta7> Respuestas7 { get; set; }
        public DbSet<Respuesta8> Respuestas8 { get; set; }
        public DbSet<Respuesta9> Respuestas9 { get; set; }
        public DbSet<Respuesta10> Respuestas10 { get; set; }
        public DbSet<EstadoMascota> EstadoMascotas { get; set; }
    }
}
