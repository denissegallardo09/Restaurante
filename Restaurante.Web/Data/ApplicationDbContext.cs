using Microsoft.EntityFrameworkCore;
using Restaurante.Web.Models;

namespace Restaurante.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
            public DbSet<Sede> sedes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Sede>()
                .HasIndex(t => t.Name)
                .IsUnique();
        }
    }
}
