using MusicApp.Services.DTOs;

namespace MusicApp.Services.Interfaces
{
    public interface ILibraryManager
    {
        Task<List<SongLibraryDTO>> GetSongsLibrary();
        Task<SongWithArtistsDTO> GetSongWithArtists(int? songId);
        Task<int> SetArtistsToSong(SongWithArtistsDTO dto);
        Task<SongWithAlbumsDTO> GetSongsWithAlbums(int? songId);
        Task<int> SetAlbumsToSong(SongWithAlbumsDTO dto);
    }
}
