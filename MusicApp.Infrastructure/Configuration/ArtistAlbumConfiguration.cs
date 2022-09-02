using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Infrastructure.Configuration
{
    public class ArtistAlbumConfiguration : ConfigurationBase<ArtistAlbum>
    {
        public override void Configure(EntityTypeBuilder<ArtistAlbum> builder)
        {
            builder.HasData
            (
                new ArtistAlbum()
                {
                    Id = 1,
                    AlbumId = 1,
                    ArtistId = 2,
                },

                new ArtistAlbum()
                {
                    Id = 2,
                    AlbumId = 2,
                    ArtistId = 3,
                },

                new ArtistAlbum()
                {
                    Id = 3,
                    AlbumId = 3,
                    ArtistId = 3,
                },

                new ArtistAlbum()
                {
                    Id = 4,
                    AlbumId = 4,
                    ArtistId = 1,
                },

                new ArtistAlbum()
                {

                    Id = 5,
                    AlbumId = 5,
                    ArtistId = 1,
                }
            );
        }
    }
}
