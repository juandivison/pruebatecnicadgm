using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;

namespace WebApi.Prueba.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
        {

        }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Equipo> Equipo { get; set; }        
        public virtual DbSet<Jugador> Jugador { get; set; }        

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

            modelBuilder.Entity<Jugador>().HasRequired(w => w.Equipo).WithMany()
            .Map(m => m.MapKey("FK_Sections_Documents"));


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Equipo>().HasMany(e => e.Jugadores);
            modelBuilder.Entity<Jugador>().HasMany(j => j.Equipos);
            modelBuilder.Entity<Pais>().HasMany(p => p.Equipos);
        }
    }
}
