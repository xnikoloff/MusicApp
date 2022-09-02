﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MusicApp.Services.Interfaces;

namespace MusicApp.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IArtistService, ArtistService>();
            services.AddTransient<ISongService, SongService>();
            return services;
        }
    }
}