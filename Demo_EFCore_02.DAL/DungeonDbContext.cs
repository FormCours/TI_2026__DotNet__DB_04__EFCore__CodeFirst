using Demo_EFCore_02.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Demo_EFCore_02.DAL
{
    public class DungeonDbContext : DbContext
    {
        // Ctor avec les options (via injection de dépendence)
        public DungeonDbContext(DbContextOptions options) : base(options) {  }

        // Ensembles des tables de la DB
        public DbSet<PlayerEntity> Players { get; set; }

        // Application config
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ↓ Récuperation des config dans le projet
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
