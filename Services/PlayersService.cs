using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreSecondLevelCacheInterceptorPG.Data;
using EFCoreSecondLevelCacheInterceptorPG.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSecondLevelCacheInterceptorPG.Services
{
    public class PlayersService
    {
        private readonly UltimateTeamContext _context;

        public PlayersService(UltimateTeamContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Player>> GetPlayers()
        {
            var query = _context.Players
                .Include(r => r.Cards)
                .Select(r => new Player
                {
                    FirstName = r.FirstName,
                    LastName = r.LastName,
                    Cards = r.Cards
                });

            return await query.ToListAsync().ConfigureAwait(false);
        }
    }
}
