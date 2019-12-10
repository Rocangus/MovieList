using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieList.Models
{
    public class MovieListContext : DbContext
    {
        public MovieListContext (DbContextOptions<MovieListContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasData(
                    new Movie { Id = 1, Title = "Titanic", Genre = Genres.Drama, ReleaseDate = DateTime.Parse("1997-02-25"), Rating = 5.0F },
                    new Movie { Id = 2, Title = "Screem", Genre = Genres.Horror, ReleaseDate = DateTime.Parse("2005-07-25"), Rating = 2.3F },
                    new Movie { Id = 3, Title = "The Shining", Genre = Genres.Horror, ReleaseDate = DateTime.Parse("1997-05-30"), Rating = 4.4F }
                );
        }

        public DbSet<MovieList.Models.Movie> Movie { get; set; }
    }
}
