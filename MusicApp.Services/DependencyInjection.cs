using Microsoft.Extensions.DependencyInjection;
using MusicApp.Services.Interfaces;

namespace MusicApp.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAlbumService, AlbumService>();
            services.AddTransient<ISongService, SongService>();
            services.AddTransient<IArtistService, ArtistService>();
            services.AddTransient<ILibraryManager, LibraryManager>();
            return services;
        }
    }
}
