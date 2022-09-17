using MusicApp.Domain.Entities;
using MusicApp.Domain.Enumerations;

namespace MusicApp.Web.ViewModels
{
    public class CreateSongViewModel
    {
        public string? Title { get; set; }
        public Genre Genre { get; set; }
        public string? MainArtistName { get; set; }
        public string? MainArtistId { get; set; }
        public List<Artist>? FeaturingArtists { get; set; }
    }
}
