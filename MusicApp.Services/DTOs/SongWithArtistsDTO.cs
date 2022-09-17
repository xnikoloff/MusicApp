using MusicApp.Domain.Entities;

namespace MusicApp.Services.DTOs
{
    public class SongWithArtistsDTO
    {
        public Song? Song { get; set; }
        public List<Artist>? Artists { get; set; }
    }
}
