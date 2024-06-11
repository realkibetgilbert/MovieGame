using Microsoft.EntityFrameworkCore;
using MovieGame.Core.Services;
using MovieGame.MODEL;

namespace MovieGame.Infrastructure.SqlServerImplementations
{
    public class VideoGameService : IVideoGameService
    {
        private readonly ApplicationContext _context;

        public VideoGameService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task AddGameAsync(MovieeGame movieeGame)
        {
            _context.MovieGames.Add(movieeGame);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteGameAsync(int id)
        {
            var game = await _context.MovieGames.FindAsync(id);

            if (game != null)
            {
                _context.MovieGames.Remove(game);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<MovieeGame> GetAllGameByIdAsync(int id)
        {
            var game = await _context.MovieGames.FindAsync(id);
            return game;
        }

        public async Task<List<MovieeGame>> GetAllGamesAsync()
        {
            return await _context.MovieGames.ToListAsync();
        }

        public async Task UpdateGameAsync(MovieeGame movieeGame, int id)
        {
            var game = await _context.MovieGames.FindAsync(id);
            if (game != null)
            {
                game.Title = movieeGame.Title;
                game.Publisher = movieeGame.Publisher;
                game.ReleaseYear = movieeGame.ReleaseYear;

                await _context.SaveChangesAsync();
            }
        }
    }
}
