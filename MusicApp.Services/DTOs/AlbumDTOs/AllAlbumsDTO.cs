using MusicApp.Services.Common;
using System.ComponentModel.DataAnnotations;

namespace MusicApp.Services.DTOs.AlbumDTOs
{
    public class AllAlbumsDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        [Display(Name = DTOConstraints.AlbumReleaseDateDisplay)]
        public DateTime ReleaseDate { get; set; }

        public List<string>? Songs { get; set; }

        public List<string>? AlbumGenres { get; set; }
    }
}
