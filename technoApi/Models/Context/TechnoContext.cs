using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace technoApi.Models
{
    public class TechnoContext: DbContext
    {
        public TechnoContext(DbContextOptions<TechnoContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            
            modelBuilder.Entity<Profile>().ToTable("Profiles");
            modelBuilder.Entity<User>().ToTable("Users");

            modelBuilder.Entity<User>()
                .HasOne(a => a.Profile);
        }
    }
}