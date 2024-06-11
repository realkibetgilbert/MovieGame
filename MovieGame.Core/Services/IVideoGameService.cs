using MovieGame.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGame.Core.Services
{
    public interface IVideoGameService
    {
        Task<List<MovieeGame>> GetAllGamesAsync();
        Task<MovieeGame> GetAllGameByIdAsync(int id);
        Task AddGameAsync(MovieeGame movieeGame);
        Task UpdateGameAsync(MovieeGame movieeGame, int id);
        Task DeleteGameAsync( int id);
    }
}
