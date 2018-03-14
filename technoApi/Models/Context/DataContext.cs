using Microsoft.EntityFrameworkCore;

namespace technoApi.Models.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Widget> Widgets { get; set; }
    }
}