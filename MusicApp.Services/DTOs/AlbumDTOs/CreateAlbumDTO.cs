using MusicApp.Services.Common;
using System.ComponentModel.DataAnnotations;

namespace MusicApp.Services.DTOs.AlbumDTOs
{
    public class CreateAlbumDTO
    {
        [Required(ErrorMessage = DTOConstraints.AlbumNameRequiredMessage)]
        [MaxLength(DTOConstraints.AlbumNameMaxLength)]
        public string Name { get; set; } = null!;

        [DataType(DataType.Date)]
        [Display(Name = DTOConstraints.AlbumReleaseDateDisplay)]
        public DateTime ReleaseDate { get; set; }
    }
}
