using Microsoft.EntityFrameworkCore;
using MovieWeb.Models;

namespace MovieWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

       public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Movie>().HasData(
               new Movie { Id=1, Title="Oppenheimer", Description="An interesting movie" },

               new Movie { Id = 2, Title = "Barbie", Description = "An interesting movie" },

               new Movie { Id = 3, Title = "Home Alone", Description = "An interesting movie" },

               new Movie { Id = 4, Title = "Harry Potter", Description = "An interesting movie" }
               
               
               );
         }
   
}


    }

