using Microsoft.EntityFrameworkCore;
using MusicApp.Domain.Entities;
using MusicApp.Infrastructure;
using MusicApp.Services.DTOs;
using MusicApp.Services.Interfaces;

namespace MusicApp.Services
{
    public class LibraryManager : ILibraryManager
    {
        private readonly MusicAppDbContext _context;

        public LibraryManager(MusicAppDbContext context)
        {
            _context = context;
        }

        public async Task<List<SongLibraryDTO>> GetSongsLibrary()
        {
            List<SongLibraryDTO> dto = await _context.Songs
                .Include(s => s.Albums)
                .Include(s => s.Artists)
                .Select(s => new SongLibraryDTO
                {
                    SongId = s.Id,
                    SongTitle = s.Title,
                    SongGenre = s.Genre.ToString(),
                    Albums = s.Albums.ToList(),
                    Artists = s.Artists.ToList()
                }).ToListAsync() ?? new List<SongLibraryDTO>();

            if(dto == null)
            {
                throw new NullReferenceException($"{nameof(SongLibraryDTO)} is null");
            }

            return dto;
        }

        public async Task<SongWithArtistsDTO> GetSongWithArtists(int? songId)
        {
            if (songId == null)
            {
                throw new NullReferenceException($"{nameof(songId)} is null");
            }

            SongWithArtistsDTO dto = await _context.Songs
                .Include(s => s.Albums)
                .Where(s => s.Id == songId)
                .Select(s => new SongWithArtistsDTO
                {
                    Song = s,
                    Artists = s.Artists.ToList()
                }).FirstOrDefaultAsync() ?? new SongWithArtistsDTO();

            if (dto.Song == null)
            {
                throw new NullReferenceException($"{nameof(dto.Song)} is null");
            }

            return dto;
        }

        public async Task<int> SetArtistsToSong(SongWithArtistsDTO dto)
        {
            Song? song = await _context.Songs.FindAsync(dto.Song?.Id);

            if(song == null)
            {
                throw new NullReferenceException($"{nameof(song)} is null");
            }


            song.Artists = dto.Artists ?? throw new NullReferenceException($"{nameof(dto.Artists)} is null");
            return await _context.SaveChangesAsync();
        }

        public async Task<SongWithAlbumsDTO> GetSongsWithAlbums(int? songId)
        {
            if(songId == null)
            {
                throw new NullReferenceException($"{nameof(songId)} is null");
            }

            SongWithAlbumsDTO dto = await _context.Songs
                .Include(s => s.Albums)
                .Where(s => s.Id == songId)
                .Select(s => new SongWithAlbumsDTO
                {
                    Song = s,
                    Albums = s.Albums.ToList()
                }).FirstOrDefaultAsync() ?? new SongWithAlbumsDTO();

            if(dto.Song == null)
            {
                throw new NullReferenceException($"{nameof(dto.Song)} is null");
            }

            return dto; 
        }

        public async Task<int> SetAlbumsToSong(SongWithAlbumsDTO dto)
        {
            Song? song = await _context.Songs.FindAsync(dto.Song?.Id);

            if (song == null)
            {
                throw new NullReferenceException($"{nameof(song)} is null");
            }

            //?? new List<Album>() is used to unassign all albums for a song
            song.Albums = dto?.Albums ?? new List<Album>();
            return await _context.SaveChangesAsync();
        }

        
    }
}
