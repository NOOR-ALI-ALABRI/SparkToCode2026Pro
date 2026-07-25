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
        
        //Insert
        Movie movie = new Movie
        {
            Title = "Inception",
            ReleaseYear = 2010,
            Rating = 8.8
        };

        context.Movies.Add(movie);
        context.SaveChanges();
        
        Movie movie2 = new Movie
        {
            Title = "Titanic",
            ReleaseYear = 1997,
            Rating = 7.8
        };

        context.Movies.Add(movie2);
        context.SaveChanges();
        
        Movie movie3 = new Movie
        {
            Title = "House of the Dragon",
            ReleaseYear = 2022,
            Rating = 8.5
        };

        context.Movies.Add(movie3);
        context.SaveChanges();
    }
}