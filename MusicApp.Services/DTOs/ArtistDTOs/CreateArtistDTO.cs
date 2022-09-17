using MusicApp.Services.Common;
using System.ComponentModel.DataAnnotations;

namespace MusicApp.Services.DTOs.ArtistDTOs
{
    public class CreateArtistDTO
    {
        [Display(Name = DTOConstraints.ArtistStageNameDisplay)]
        [Required(ErrorMessage = DTOConstraints.ArtistStageNameRequiredMessage)]
        [MaxLength(DTOConstraints.ArtistStageNameMaxLength)]
        public string? StageName { get; set; }

        [Required(ErrorMessage = DTOConstraints.ArtistRealNameRequiredMessage)]
        [MaxLength(DTOConstraints.ArtistRealNameMaxLength)]
        [Display(Name = DTOConstraints.ArtistRealNameDisplay)]
        public string? RealName { get; set; }
    }
}
