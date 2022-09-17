namespace MusicApp.Services.Common
{
    /// <summary>
    /// Model validation constraints
    /// </summary>
    public static class DTOConstraints
    {
        //Song
        public const int SongTitleMaxLength = 60;
        public const string SongTitleRequiredMessage = "Song Title is required";

        //Album
        public const int AlbumNameMaxLength = 40;
        public const string AlbumNameRequiredMessage = "Album is required";
        public const string AlbumReleaseDateDisplay = "Release Date";

        //Artist
        public const int ArtistStageNameMaxLength = 20;
        public const int ArtistRealNameMaxLength = 80;
        public const string ArtistStageNameRequiredMessage = "Stage Name is required";
        public const string ArtistRealNameRequiredMessage = "Real Name is required";
        public const string ArtistStageNameDisplay = "Stage Name";
        public const string ArtistRealNameDisplay = "Real Name";
    }
}
