using Microsoft.EntityFrameworkCore;
using MusicApp.Domain.Entities;
using MusicApp.Infrastructure.Configuration;

namespace MusicApp.Infrastructure
{
    public class MusicAppDbContext : DbContext
    {
        public MusicAppDbContext() {}

        public MusicAppDbContext(DbContextOptions<MusicAppDbContext> options)
            : base(options) {}

        public DbSet<Song>? Songs { get; set; }
        public DbSet<Artist>? Artists { get; set; }
        public DbSet<Album>? Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ArtistConfiguration());
            builder.ApplyConfiguration(new SongConfiguration());
            builder.ApplyConfiguration(new AlbumConfiguration());
        }
    }
}