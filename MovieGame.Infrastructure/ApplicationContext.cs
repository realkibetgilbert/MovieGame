using Microsoft.EntityFrameworkCore;
using MovieGame.MODEL;

namespace MovieGame.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<MovieeGame> MovieGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MovieeGame>().HasData(
                new MovieeGame
                {
                    Id = 1,
                    Title = "Example Game",
                    Publisher = "Example Publisher",
                    ReleaseYear = 2020
                },
                new MovieeGame
                {
                    Id = 2,
                    Title = "Second Game",
                    Publisher = "Second Publisher",
                    ReleaseYear = 2021
                },
                new MovieeGame
                {
                    Id = 3,
                    Title = "Third Game",
                    Publisher = "Third Publisher",
                    ReleaseYear = 2022
                }
            );

        }
    }
}
