using System.ComponentModel.DataAnnotations;

namespace MusicApp.Domain.Entities
{
    public class Album
    {
        public Album()
        {
            Songs = new HashSet<Song>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        
        public DateTime ReleaseDate { get; set; }

        public IEnumerable<Song> Songs{ get; set; }
    }
}