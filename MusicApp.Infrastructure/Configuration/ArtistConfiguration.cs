using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicApp.Domain.Entities;

namespace MusicApp.Infrastructure.Configuration
{
    public class ArtistConfiguration : ConfigurationBase<Artist>
    {
        public override void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasData
            (
                new Artist
                {
                    Id = 1,
                    RealName = "Marshall Mathers",
                    StageName = "Eminem"
                },

                new Artist
                {
                    Id = 2,
                    RealName = "Abel Makkonen Tesfaye",
                    StageName = "The Weeknd"
                },
                
                new Artist
                {
                    Id = 3,
                    RealName = "Cameron Jibril Thomaz",
                    StageName = "Wiz Khalifa"
                }
            );
        }
    }
}
