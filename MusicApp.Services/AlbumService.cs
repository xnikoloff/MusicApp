using Microsoft.EntityFrameworkCore;
using MusicApp.Domain.Entities;
using MusicApp.Infrastructure;
using MusicApp.Services.DTOs.AlbumDTOs;
using MusicApp.Services.Interfaces;

namespace MusicApp.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly MusicAppDbContext _context;

        public AlbumService(MusicAppDbContext context)
        {
            _context = context;
        }


        public async Task<Album> GetById(int? id)
        {
            if(id == null)
            {
                throw new NullReferenceException($"{nameof(id)} is null");
            }

            Album? album = await _context.Albums
                .Include(a => a.Songs)
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();

            if(album == null)
            {
                throw new NullReferenceException($"{nameof(album)} does not exists");
            }

            return album;
        }

        public async Task<List<AllAlbumsDTO>> All()
        {
            return await _context.Albums
                .Include(a => a.Songs)
                .ThenInclude(s => s.Artists)
                .Select(a => new AllAlbumsDTO
                {
                    Id = a.Id,
                    Name = a.Name,
                    ReleaseDate = a.ReleaseDate,
                    Songs = a.Songs.Select(s => s.Title).ToList(),
                    AlbumGenres = a.Songs.Select(s => s.Genre.ToString()).Distinct().ToList()
                }).ToListAsync();
        }

        public async Task<int> Create(CreateAlbumDTO viewModel)
        {
            if (viewModel.Name == null)
            {
                throw new NullReferenceException($"{nameof(viewModel.Name)} is null");
            }

            Album album = new()
            {
                Name = viewModel.Name,
                ReleaseDate = viewModel.ReleaseDate,
            };

            await _context.Albums.AddAsync(album);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(UpdateAlbumDTO dto)
        {
            Album? existingAlbum = await _context.Albums.FindAsync(dto.Id);

            if (existingAlbum == null)
            {
                throw new NullReferenceException($"{nameof(dto)} is null");
            }

            existingAlbum.Name = dto.Name ?? throw new NullReferenceException($"{nameof(dto.Name)} is null");
            existingAlbum.ReleaseDate = dto.ReleaseDate;

            return await _context.SaveChangesAsync();
        }


        public async Task<int> Delete(int? id)
        {
            if (id == 0)
            {
                throw new ArgumentException($"{id} is 0");
            }
            Album? album = await _context.Albums.FindAsync(id);

            if (album != null)
            {
                _context.Albums.Remove(album);
                return await _context.SaveChangesAsync();
            }

            throw new NullReferenceException($"{nameof(album)} is null. No album with that ID exists.");
        }

        
    }
}
