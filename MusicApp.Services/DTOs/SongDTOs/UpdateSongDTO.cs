using MusicApp.Domain.Enumerations;

namespace MusicApp.Services.DTOs.SongDTOs
{
    public class UpdateSongDTO
    {
        public int Id { get; set; }
        public string? SongTitle { get; set; }
        public Genre Genre { get; set; }
    }
}
