using Microsoft.EntityFrameworkCore;
using MusicApp.Domain.Entities;
using MusicApp.Infrastructure;
using MusicApp.Services.Interfaces;

namespace MusicApp.Services
{
    public class ArtistService : IArtistService
    {
        private readonly MusicAppDbContext _context;

        public ArtistService(MusicAppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Artist>> All()
        {
            if (_context.Artists != null)
            {
                return await _context.Artists.ToListAsync();
            }

            throw new NullReferenceException($"{nameof(_context.Artists)} is null");
        }
    }
}
