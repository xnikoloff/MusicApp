using MusicApp.Domain.Entities;
using MusicApp.Services.DTOs.AlbumDTOs;

namespace MusicApp.Services.Interfaces
{
    public interface IAlbumService : IEntityServiceBase<Album>
    {
        Task<int> Create(CreateAlbumDTO viewModel);
        Task<int> Update(UpdateAlbumDTO viewModel);
        Task<List<AllAlbumsDTO>> All();
    }
}
