using System;
using System.IO;
using DesktopApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DesktopApp.DataAccess
{
    public class ShellFishDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal), 
                "ShellFishData.db");
            optionsBuilder.UseSqlite(
                $"Data Source={connectionString}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Asset>().ToTable("Assets");
        }
        
        public DbSet<Blogpost> Blogposts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Podcast> Podcasts { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}