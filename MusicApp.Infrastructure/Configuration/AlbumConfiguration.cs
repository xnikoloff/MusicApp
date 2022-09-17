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
    public class AlbumConfiguration : ConfigurationBase<Album>
    {
        public override void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasData
            (
                new Album()
                {
                    Id = 1,
                    Name = "Starboy",
                    ReleaseDate = new DateTime(2016, 11, 25),
                },

                new Album()
                {
                    Id = 2,
                    Name = "Rolling Papers",
                    ReleaseDate = new DateTime(2011, 03, 29),
                },

                new Album()
                {
                    Id = 3,
                    Name = "Blacc Hollywood",
                    ReleaseDate = new DateTime(2014, 08, 19),
                },

                new Album()
                {
                    Id = 4,
                    Name = "The Marshall Mathers",
                    ReleaseDate = new DateTime(2000, 05, 23),
                },

                new Album()
                {
                    Id = 5,
                    Name = "Music to Be Murdered By",
                    ReleaseDate = new DateTime(2020, 01, 17),
                }
            );
        }
    }
}
