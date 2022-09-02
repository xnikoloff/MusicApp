using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Infrastructure.Configuration
{
    public class ArtistSongConfiguration : ConfigurationBase<ArtistSong>
    {
        public override void Configure(EntityTypeBuilder<ArtistSong> builder)
        {
            builder.HasData
            (
                new ArtistSong
                {
                    Id = 1,
                    ArtistId = 1,
                    SongId = 4,
                },

                new ArtistSong
                {

                    Id = 2,
                    ArtistId = 1,
                    SongId = 5,
                },

                new ArtistSong
                {

                    Id = 3,
                    ArtistId = 2,
                    SongId = 3,
                },

                new ArtistSong
                {
                    Id = 4,
                    ArtistId = 3,
                    SongId = 1,
                },

                new ArtistSong
                {
                    Id = 5,
                    ArtistId = 3,
                    SongId = 2,
                }
            );
        }
    }
}
