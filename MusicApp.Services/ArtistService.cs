using Microsoft.EntityFrameworkCore;
using MusicApp.Domain.Entities;
using MusicApp.Infrastructure;
using MusicApp.Services.DTOs.ArtistDTOs;
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

        public async Task<Artist> GetById(int? id)
        {
            if(id == null)
            {
                throw new NullReferenceException($"{nameof(id)} is null");
            }

            Artist? artist = await _context.Artists.FindAsync(id);

            if(artist == null)
            {
                throw new NullReferenceException($"{nameof(artist)} does not exists");
            }

            return artist;
        }

        public async Task<List<AllArtistsDTO>> All()
        {
            return await _context.Artists
                .Include(ar => ar.Songs)
                .Select(a => new AllArtistsDTO
                {
                    Id = a.Id,
                    StageName = a.StageName
                })
                .ToListAsync();
        }

        public async Task<int> Create(CreateArtistDTO dto)
        {
            if (dto == null)
            {
                throw new NullReferenceException(nameof(dto));
            }

            Artist artist = new()
            {
                StageName = dto.StageName ?? throw new NullReferenceException($"{nameof(dto.StageName)} is null"),
                RealName = dto.RealName ?? throw new NullReferenceException($"{nameof(dto.RealName)} is null")
            };

            await _context.Artists.AddAsync(artist);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(UpdateArtistDTO dto)
        {
            Artist? artist = await _context.Artists.FindAsync(dto.Id);

            if(artist == null)
            {
                throw new NullReferenceException($"{nameof(artist)} does not exists");
            }

            artist.StageName = dto.StageName ?? throw new NullReferenceException($"{nameof(dto.StageName)} is null");
            artist.RealName = dto.RealName ?? throw new NullReferenceException($"{nameof(dto.RealName)} is null");

            return await _context.SaveChangesAsync();
            
        }

        public async Task<int> Delete(int? id)
        {
            if(id == null)
            {
                throw new NullReferenceException($"{nameof(id)} is null");
            }

            Artist? artist = await _context.Artists.FindAsync(id);

            _context.Artists.Remove(artist ?? throw new NullReferenceException($"{nameof(artist)} does not exists"));

            return await _context.SaveChangesAsync();
        }
    }
}
