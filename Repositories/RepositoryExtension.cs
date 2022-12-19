using Microsoft.Extensions.DependencyInjection;

namespace Muzic.Repositories
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services;
        }
    }
}