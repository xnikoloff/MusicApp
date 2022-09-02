using MusicApp.Domain.Common;
using System.ComponentModel.DataAnnotations;
using MusicApp.Domain.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApp.Domain.Entities
{
    public class Song
    {
        public Song()
        {
            ArtistsSongs = new HashSet<ArtistSong>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ModelConstraints.SongTitleMaxLength)]
        public string Title { get; set; } = null!;

        public Genre Genre { get; set; }

        [ForeignKey(nameof(MainArtist))]
        public int MainArtistId { get; set; }
        public Artist? MainArtist { get; set; }

        public IEnumerable<ArtistSong> ArtistsSongs { get; set; }
    }
}
