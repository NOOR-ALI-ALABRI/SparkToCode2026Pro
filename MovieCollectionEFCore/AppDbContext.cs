using Microsoft.EntityFrameworkCore;
using MovieCollectionEFCore.Models;

namespace MovieCollectionEFCore.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Director> Directors { get; set; }

       // Connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=.;Database=MovieCollectionDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}