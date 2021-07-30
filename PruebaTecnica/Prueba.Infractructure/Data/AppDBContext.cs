using Microsoft.EntityFrameworkCore;
using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Prueba.Infractructure.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Equipo> Equipo { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Jugador> Jugador { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());            
            modelBuilder.Entity<Equipo>().HasMany(e => e.Jugadores).WithOne();            
            modelBuilder.Entity<Jugador>().HasMany(j => j.Equipos).WithMany(p => p.Jugadores);
            modelBuilder.Entity<Pais>().HasMany(p => p.Equipos);
        }
    } 
}
