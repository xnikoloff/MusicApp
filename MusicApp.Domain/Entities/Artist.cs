using System.ComponentModel.DataAnnotations;

namespace MusicApp.Domain.Entities
{
    public class Artist
    {
        public Artist()
        {
            Songs = new HashSet<Song>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string StageName { get; set; } = null!;

        public string RealName { get; set; } = null!;

        public IEnumerable<Song> Songs { get; set; }
    }
}
