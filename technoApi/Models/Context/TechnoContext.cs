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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            
            modelBuilder.Entity<Profile>().ToTable("Profiles");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Title>().ToTable("Titles");
            modelBuilder.Entity<JobType>().ToTable("JobTypes");
            modelBuilder.Entity<JobTitle>().ToTable("JobTitles");

            modelBuilder.Entity<User>().HasOne(a => a.Profile);
            modelBuilder.Entity<Profile>().HasOne(a => a.Title);
            modelBuilder.Entity<Profile>().HasOne(a => a.JobType);
            modelBuilder.Entity<Profile>().HasOne(a => a.JobTitle);
        }
    }
}