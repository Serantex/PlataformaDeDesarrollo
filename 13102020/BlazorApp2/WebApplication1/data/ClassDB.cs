using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.model;


namespace apiNet.data
{
    public class TareasDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Usuario>().Property(p => p.clave).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Usuario>().Property(p => p.id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Recurso>().ToTable("Recurso");
            modelBuilder.Entity<Recurso>().Property(n => n.nombre).HasMaxLength(50);
            modelBuilder.Entity<Recurso>().Property(n => n.id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Tarea>().ToTable("Tarea");
            modelBuilder.Entity<Tarea>().Property(t => t.id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Tarea>().Property(t => t.estado).IsRequired();

            modelBuilder.Entity<Detalle>().ToTable("Detalle");
            modelBuilder.Entity<Detalle>().Property(d => d.id).ValueGeneratedOnAdd();

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Detalle> Detalle { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Recurso> Recursos { get; set; }

    }
}