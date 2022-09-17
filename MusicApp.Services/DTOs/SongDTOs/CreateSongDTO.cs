using MusicApp.Domain.Enumerations;
using MusicApp.Services.Common;
using System.ComponentModel.DataAnnotations;

namespace MusicApp.Services.DTOs.SongDTOs
{
    public class CreateSongDTO
    {
        [MaxLength(DTOConstraints.SongTitleMaxLength)]
        [Required(ErrorMessage = DTOConstraints.SongTitleRequiredMessage)]
        [Display(Name = "Title")]
        public string? SongTitle { get; set; }

        public Genre Genre { get; set; }
    }
}
