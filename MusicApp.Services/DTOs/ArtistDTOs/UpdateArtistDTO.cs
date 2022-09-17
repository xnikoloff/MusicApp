using MusicApp.Services.Common;
using System.ComponentModel.DataAnnotations;

namespace MusicApp.Services.DTOs.ArtistDTOs
{
    public class UpdateArtistDTO
    {
        public int Id { get; set; }

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
