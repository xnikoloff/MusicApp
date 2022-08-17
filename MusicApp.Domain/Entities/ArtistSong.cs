using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApp.Domain.Entities
{
    public class ArtistSong
    {
        [ForeignKey(nameof(Artist))]
        public int ArtistId { get; set; }

        public Artist Artist { get; set; } = null!;

        [ForeignKey(nameof(Song))]
        public int SongId { get; set; }

        public Song Song { get; set; } = null!;

        [ForeignKey(nameof(MainArtist))]
        public int MainArtistId { get; set; }

        public Artist? MainArtist { get; set; }
    }
}
