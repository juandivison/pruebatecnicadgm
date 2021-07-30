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

        public virtual DbSet<Equipo> Equipos { get; set; }
        public virtual DbSet<Estado> Etadoss { get; set; }
        public virtual DbSet<Jugador> Jugador { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());            
            modelBuilder.Entity<Equipo>().HasMany(e => e.Jugador).WithOne();            
            modelBuilder.Entity<Jugador>().HasOne(j => j.Equipo).WithMany();
            modelBuilder.Entity<Pais>().HasMany(p => p.Equipo);
        }
    } 
}
