using Microsoft.Extensions.DependencyInjection;
using Muzic.Repositories.MusicRepositories;

namespace Muzic.Repositories
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IMusicRepository, MusicRepository>();
            return services;
        }
    }
}