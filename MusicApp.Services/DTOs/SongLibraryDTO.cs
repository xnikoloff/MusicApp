using MusicApp.Domain.Entities;

namespace MusicApp.Services.DTOs
{
    public class SongLibraryDTO
    {
        public int SongId { get; set; }
        public string? SongTitle { get; set; }
        public string? SongGenre { get; set; }

        public List<Album>? Albums { get; set; }
        public List<Artist>? Artists { get; set; }
    }
}
