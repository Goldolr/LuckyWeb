using LuckyWeb.Models;
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
    }
}
