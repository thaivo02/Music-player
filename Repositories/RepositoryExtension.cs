using Microsoft.Extensions.DependencyInjection;
using Muzic.Repositories.ArtistRepositories;
using Muzic.Repositories.MusicRepositories;
using Muzic.Repositories.PlaylistRepositories;

namespace Muzic.Repositories
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IMusicRepository, MusicRepository>();
            services.AddScoped<IArtistRepository, ArtistRepository>();
            services.AddScoped<IPlaylistRepository, PlaylistRepository>();
            return services;
        }
    }
}