namespace WebApplication1;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

public class UniversityContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    public DbSet<Department> Departments { get; set; }
    
    
   public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
   {
   }
}