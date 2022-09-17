using Microsoft.EntityFrameworkCore;
using MusicApp.Domain.Entities;
using MusicApp.Infrastructure;
using MusicApp.Services.DTOs.SongDTOs;
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

        public async Task<Song> GetById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException($"{nameof(id)} is null");
            }

            Song? song = await _context.Songs
                .Include(s => s.Artists)
                .Include(s => s.Albums)
                .Where(s => s.Id == id)
                .FirstOrDefaultAsync();

            if (song == null)
            {
                throw new NullReferenceException($"{nameof(song)} does not exists");
            }

            return song;
        }

        public async Task<List<AllSongsDTO>> All()
        {
            var songs = await _context.Songs
                .Include(s => s.Artists)
                .Include(s => s.Albums)
                .Select(s => new AllSongsDTO
                {
                    Id = s.Id,
                    SongTitle = s.Title,
                    Genre = s.Genre.ToString(),
                    AlbumName = s.Albums.Select(a => a.Name).FirstOrDefault(),
                    ArtistsNames = s.Artists.Select(a => a.StageName).ToList()
                }).ToListAsync();

            return songs;
        }

        public async Task<int> Create(CreateSongDTO dto)
        {
            if (dto == null)
            {
                throw new NullReferenceException($"{nameof(dto)} is null");
            }

            Song song = new()
            {
                Title = dto.SongTitle ?? throw new NullReferenceException($"{dto.SongTitle} is null"),
                Genre = dto.Genre,
            };

            await _context.Songs.AddAsync(song);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(UpdateSongDTO dto)
        {
            Song? song = await _context.Songs.FindAsync(dto.Id);

            if (song == null)
            {
                throw new NullReferenceException($"{nameof(song)} is null");
            }

            song.Title = dto.SongTitle ?? throw new NullReferenceException($"{nameof(dto.SongTitle)} is null");
            song.Genre = dto.Genre;

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int? id)
        {
            Song? song = await _context.Songs.FindAsync(id);

            if (song == null)
            {
                throw new NullReferenceException($"{nameof(song)} does not exists.");
            }

            _context.Songs.Remove(song);
            return await _context.SaveChangesAsync();
        }

        public async Task<Song> GetSongByArtist(int artistId)
        {
            List<Song> songs = await _context.Songs.ToListAsync();
            Song? song = songs.FirstOrDefault();

            if (song == null)
            {
                throw new NullReferenceException($"{songs} is null");
            }

            return song;
        }
    }
}