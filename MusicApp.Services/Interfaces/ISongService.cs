using MusicApp.Domain.Entities;
using MusicApp.Services.DTOs.SongDTOs;

namespace MusicApp.Services.Interfaces
{
    public interface ISongService : IEntityServiceBase<Song>
    {
        Task<List<AllSongsDTO>> All();
        Task<int> Create(CreateSongDTO viewModel);
        Task<int> Update(UpdateSongDTO dto);
        Task<Song> GetSongByArtist(int artistId);
    }
}
