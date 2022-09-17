using MusicApp.Domain.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace MusicApp.Domain.Entities
{
    public class Song
    {
        public Song()
        {
            Artists = new HashSet<Artist>();
            Albums = new HashSet<Album>();
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        [Required]
        public Genre Genre { get; set; }

        public IEnumerable<Artist> Artists { get; set; }
        public IEnumerable<Album> Albums { get; set; }
    }
}
