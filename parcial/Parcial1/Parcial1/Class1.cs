using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1
{
    public class TareasDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>().ToTable("Usuario")
                                          .Property(p => p.clave).HasMaxLength(50);

            modelBuilder.Entity<Recurso>().ToTable("Recurso")
                                          .Property(n => n.nombre).HasMaxLength(50);

            modelBuilder.Entity<Tarea>().ToTable("Tarea")
                                        .Property(t=>t.estado).IsRequired();

            modelBuilder.Entity<Detalle>().ToTable("Detalle");
                                         

        }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
