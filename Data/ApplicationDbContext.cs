using AutoBiography.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoBiography.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories{ get; set; }

        public DbSet<UserProfile> Users{ get; set; }

        public DbSet<UserSavedPics> UserSavedPics{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Sedan"},
                new Category { Id = 2, Name = "SUV"},
                new Category { Id = 3, Name = "Sport"}
                );
        }
    }
}
