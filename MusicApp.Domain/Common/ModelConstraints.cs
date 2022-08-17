using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Domain.Common
{
    public static class ModelConstraints
    {
        //Song
        public const int SongTitleMaxLength = 100;

        //Artist
        public const int ArtistRealNameMaxLength = 80;
        public const int ArtistStageNameMaxLength = 40;

        //Album
        public const int AlbumTitleMaxLength = 100;
    }
}
