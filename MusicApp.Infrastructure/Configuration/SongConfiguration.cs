using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicApp.Domain.Entities;
using MusicApp.Domain.Enumerations;

namespace MusicApp.Infrastructure.Configuration
{
    public class SongConfiguration : ConfigurationBase<Song>
    {
        public override void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasData
            (
                new Song
                {
                    Id = 1,
                    Title = "Black and Yellow",
                    Genre = Genre.HipHop,
                },

                new Song
                {
                    Id = 2,
                    Title = "So High",
                    Genre = Genre.HipHop,
                },

                new Song
                {
                    Id = 3,
                    Title = "Starboy",
                    Genre = Genre.RnB,
                },

                new Song
                {
                    Id = 4,
                    Title = "Marshall Mathers",
                    Genre = Genre.HipHop,
                },

                new Song
                {
                    Id = 5,
                    Title = "No Regrets",
                    Genre = Genre.HipHop,
                }
            );
        }
    }
}
