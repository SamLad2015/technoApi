using System.Linq;
using Microsoft.EntityFrameworkCore;
using technoApi.Models.Config;
using technoApi.Models.Profile;


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
            
            //user section
            modelBuilder.Entity<User.User>().ToTable("Users");
            modelBuilder.Entity<Profile.Profile>().ToTable("Profiles");
            modelBuilder.Entity<Title>().ToTable("Titles");
            modelBuilder.Entity<JobType>().ToTable("JobTypes");
            modelBuilder.Entity<JobTitle>().ToTable("JobTitles");
            modelBuilder.Entity<JobHistory>().ToTable("JobHistory");
            modelBuilder.Entity<Qualification>().ToTable("Qualifications");
            modelBuilder.Entity<QualificationType>().ToTable("QualificationTypes");
            
            //Article Section 
            modelBuilder.Entity<Article.Article>().ToTable("Articles");
            modelBuilder.Entity<Article.Comment>().ToTable("Comments");
            
            //Widgets Section
            modelBuilder.Entity<Widget.Widget>().ToTable("Widgets");
            modelBuilder.Entity<WidgetClass>().ToTable("WidgetClasses");
            modelBuilder.Entity<WidgetSize>().ToTable("WidgetSizes");
            
            //Menu Section
            modelBuilder.Entity<Menu.Menu>().ToTable("Menus");
            modelBuilder.Entity<FontAwesomeFont>().ToTable("FontAwesomeFonts");
            
            
            //Relationships
            

            //User
            modelBuilder.Entity<User.User>().HasOne(a => a.Profile);
            //Profile
            modelBuilder.Entity<Profile.Profile>().HasOne(a => a.Title);
            modelBuilder.Entity<Profile.Profile>().HasOne(a => a.JobType);
            modelBuilder.Entity<Profile.Profile>().HasOne(a => a.JobTitle);
            modelBuilder.Entity<Profile.Profile>().HasMany(a => a.Qualifications);
            modelBuilder.Entity<Profile.Profile>().HasMany(a => a.JobHistories);
            //Article
            modelBuilder.Entity<Article.Article>().HasMany(a => a.Comments);
            modelBuilder.Entity<Article.Comment>().HasOne(c => c.User);
            //Widget
            modelBuilder.Entity<Widget.Widget>().HasOne(w => w.WidgetClass);
            modelBuilder.Entity<Widget.Widget>().HasOne(w => w.WidgetSize);
            modelBuilder.Entity<Widget.Widget>().HasMany(w => w.ChildWidgets);
            modelBuilder.Entity<Widget.Widget>().HasOne(w => w.Article);
            //Menu
            modelBuilder.Entity<Menu.Menu>().HasOne(m => m.FontASF);
            modelBuilder.Entity<Menu.Menu>().HasOne(m => m.ParentMenu);
            modelBuilder.Entity<Menu.Menu>().HasMany(m => m.ChildMenus);
            //Qualification
            modelBuilder.Entity<Qualification>().HasOne(q => q.QualificationType);
            //JobHistory
            modelBuilder.Entity<JobHistory>().HasOne(q => q.JobType);
        }
    }
}