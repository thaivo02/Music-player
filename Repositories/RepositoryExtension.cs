using Microsoft.Extensions.DependencyInjection;
using Muzic.Repositories.ArtistRepositories;
using Muzic.Repositories.MusicRepositories;
using Muzic.Repositories.PlaylistMusicRepositories;
using Muzic.Repositories.PlaylistRepositories;
using PlaylistRepository = Muzic.Repositories.PlaylistRepositories.PlaylistRepository;

namespace Muzic.Repositories
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IMusicRepository, MusicRepository>();
            services.AddScoped<IArtistRepository, ArtistRepository>();
            services.AddScoped<IPlaylistRepository, PlaylistRepository>();
            services.AddScoped<IPlaylistMusicRepository, PlaylistMusicRepository>();
            return services;
        }
    }
}