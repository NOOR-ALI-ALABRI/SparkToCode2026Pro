using MovieCollectionEFCore.Data;
using MovieCollectionEFCore.Models;

namespace MovieCollectionEFCore;

class Program
{
    static void Main(string[] args)
    {
        // Create connection with database
        using var context = new AppDbContext();

        // DDL: Create Database and Tables
        context.Database.EnsureCreated();
        
        Movie movie = new Movie
        {
            Title = "Inception",
            ReleaseYear = 2010,
            Rating = 8.8
        };

        context.Movies.Add(movie);
        context.SaveChanges();
        
        
        
    }
}