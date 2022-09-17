using Microsoft.EntityFrameworkCore;
using MusicApp.Domain.Entities;
using MusicApp.Infrastructure;
using MusicApp.Services.Interfaces;

namespace MusicApp.Services
{
    public class SongService : ISongService
    {
        private readonly MusicAppDbContext _context;

        public SongService(MusicAppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(Song song)
        {
            if(song != null)
            {
                await _context.AddAsync(song);
                return await _context.SaveChangesAsync();
            }

            throw new NullReferenceException($"{nameof(song)} is null");
        }

        public async Task<List<Song>> All()
        {
            if(_context.Songs != null)
            {
                return await _context.Songs.Include(s => s.MainArtist).ToListAsync();
            }

            throw new NullReferenceException($"{nameof(_context.Songs)} is null");
        }
    }
}
