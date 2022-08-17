using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApp.Domain.Entities
{
    public class ArtistAlbum
    {
        [ForeignKey(nameof(Artist))]
        public int ArtistId { get; set; }

        public Artist Artist { get; set; } = null!;

        [ForeignKey(nameof(Album))]
        public int AlbumId { get; set; }

        public Album Album { get; set; } = null!;

        [ForeignKey(nameof(MainArtist))]
        public int MainArtistId { get; set; }

        public Artist MainArtist { get; set; } = null!;
    }
}
