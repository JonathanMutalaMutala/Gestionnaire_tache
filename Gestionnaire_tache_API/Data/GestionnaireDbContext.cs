using Gestionnaire_tache_API.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gestionnaire_tache_API.Data
{
    public class GestionnaireDbContext  : IdentityDbContext<ApplicationUser>
    {
        public GestionnaireDbContext(DbContextOptions<GestionnaireDbContext> options) : base(options) { }

        public DbSet<Column> Columns { get; set; }
        public DbSet<Tache> Tasks { get; set; }
        public  DbSet<ApplicationUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GestionnaireDbContext).Assembly); 
        }

    }
}
