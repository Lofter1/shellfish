using DesktopApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DesktopApp.DataAccess
{
    public class ShellFishDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CAsset>().ToTable("Assets");
        }
        
        public DbSet<CBlogpost> Blogposts { get; set; }
        public DbSet<CBook> Books { get; set; }
        public DbSet<CPodcast> Podcasts { get; set; }
        public DbSet<CSlide> Slides { get; set; }
        public DbSet<CVideo> Videos { get; set; }
    }
}