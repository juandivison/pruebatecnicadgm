using Microsoft.EntityFrameworkCore;
using Prueba.Core.Entities;
using System.Linq;
using System.Reflection;


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
            var cascadeFKs = modelBuilder.Model
            .G­etEntityTypes()
            .SelectMany(t => t.GetForeignKeys())
            .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Casca­de);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());            
            modelBuilder.Entity<Equipo>().HasMany(e => e.Jugadores).WithOne();
            modelBuilder.Entity<Jugador>().HasMany(j => j.Equipos);
            modelBuilder.Entity<Pais>().HasMany(p => p.Equipos);
        }
    } 
}
