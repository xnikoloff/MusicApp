using MusicApp.Domain.Entities;
using MusicApp.Services.DTOs.ArtistDTOs;

namespace MusicApp.Services.Interfaces
{
    public interface IArtistService : IEntityServiceBase<Artist>
    {
        Task<int> Create(CreateArtistDTO dto);
        Task<int> Update(UpdateArtistDTO dto);
        Task<List<AllArtistsDTO>> All();
    }
}
