using DesktopApp.Models;
using Microsoft.EntityFrameworkCore;
using SharpDX;

namespace DesktopApp.DataAccess
{
    public class ShellFishDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<CAsset> Assets { get; set; }
        public DbSet<CBlogpost> Blogposts { get; set; }
        public DbSet<CBook> Books { get; set; }
        public DbSet<CPodcast> Podcasts { get; set; }
        public DbSet<CSlide> Slides { get; set; }
        public DbSet<CVideo> Videos { get; set; }
    }
}