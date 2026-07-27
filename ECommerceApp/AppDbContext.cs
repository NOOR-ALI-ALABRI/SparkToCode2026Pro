using Microsoft.EntityFrameworkCore;
using ECommerceApp.Models;

namespace ECommerceApp;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost;Database=ECommerceDB;Trusted_Connection=True;TrustServerCertificate=True;"
        );
    }
}