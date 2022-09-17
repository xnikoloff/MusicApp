namespace MusicApp.Services.DTOs.SongDTOs
{
    public class AllSongsDTO
    {
        public int Id { get; set; }
        public string? SongTitle { get; set; }
        public string? Genre { get; set; }
        public List<string>? ArtistsNames { get; set; }
        public string?  AlbumName { get; set; }
    }
}
