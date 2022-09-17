using MusicApp.Domain.Entities;

namespace MusicApp.Services.DTOs
{
    public class SongWithAlbumsDTO
    {
        public Song? Song { get; set; }
        public List<Album>? Albums { get; set; }
    }
}
