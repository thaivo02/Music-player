using Microsoft.Extensions.DependencyInjection;

namespace Muzic.Services
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services;
        }
    }
}