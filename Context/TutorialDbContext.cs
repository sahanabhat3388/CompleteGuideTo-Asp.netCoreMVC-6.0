using Asp.netCoreMVCIntro.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreMVCIntro.Context
{
    public class TutorialDbContext:DbContext
    {
        public TutorialDbContext(DbContextOptions<TutorialDbContext> options) : base(options)
        {
        }
        public DbSet<Tutorial> Tutorials { get; set; }
        public DbSet<Article> Articles { get; set; }
        // seed database tables with initial data 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(
                new Article
                {
                    ArticleId = 1,
                    ArticleTitle = "Introduction to C#",
                    ArticleContent = "C# is an Object oriented language",
                    TutorialId = 1
                }
            );
        }
    }
}
