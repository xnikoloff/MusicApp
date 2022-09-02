using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApp.Domain.Entities
{
    public class ArtistAlbum
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Artist))]
        public int ArtistId { get; set; }

        public Artist Artist { get; set; } = null!;

        [ForeignKey(nameof(Album))]
        public int AlbumId { get; set; }

        public Album Album { get; set; } = null!;
    }
}
