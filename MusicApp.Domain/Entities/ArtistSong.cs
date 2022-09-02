using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApp.Domain.Entities
{
    public class ArtistSong
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Artist))]
        public int ArtistId { get; set; }

        public Artist Artist { get; set; } = null!;

        [ForeignKey(nameof(Song))]
        public int SongId { get; set; }

        public Song Song { get; set; } = null!;
    }
}
