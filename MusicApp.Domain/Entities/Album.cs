using MusicApp.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApp.Domain.Entities
{
    public class Album
    {
        public Album()
        {
            ArtistsAlbums = new HashSet<ArtistAlbum>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ModelConstraints.AlbumTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Display(Name = DisplayName.AlbumReleaseDate)]
        public DateTime ReleaseDate { get; set; }

        public IEnumerable<ArtistAlbum> ArtistsAlbums { get; set; }
    }
}