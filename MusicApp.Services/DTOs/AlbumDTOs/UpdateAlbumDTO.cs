using MusicApp.Services.Common;
using System.ComponentModel.DataAnnotations;

namespace MusicApp.Services.DTOs.AlbumDTOs
{
    public class UpdateAlbumDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = DTOConstraints.AlbumNameRequiredMessage)]
        [MaxLength(DTOConstraints.AlbumNameMaxLength)]
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
