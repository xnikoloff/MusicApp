using MusicApp.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace MusicApp.Domain.Entities
{
    public class Artist
    {
        public Artist()
        {
            ArtistsAlbums = new HashSet<ArtistAlbum>();
            ArtistsSongs = new HashSet<ArtistSong>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ModelConstraints.ArtistStageNameMaxLength)]
        [Display(Name = DisplayName.ArtistStageName)]
        public string StageName { get; set; } = null!;

        [MaxLength(ModelConstraints.ArtistRealNameMaxLength)]
        [Display(Name = DisplayName.ArtistRealName)]
        public string RealName { get; set; } = null!;

        public IEnumerable<ArtistAlbum> ArtistsAlbums { get; set; }

        public IEnumerable<ArtistSong> ArtistsSongs { get; set; }
    }
}
