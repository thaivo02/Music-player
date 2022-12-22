using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Muzic.Database;
using Muzic.Repositories;
using Muzic.Services;

namespace Muzic
{
    public static class Program
    {
        private static ApplicationDbContext? _dbContext;
        public static IHost host = Host.CreateDefaultBuilder()
            .ConfigureServices(c =>
            {
                c.AddDbContext<ApplicationDbContext>(s =>
                {
                    s.UseSqlServer("Server=localhost;Database=Muzic;Trusted_Connection=True;Encrypt=False");
                });
                c.AddRepositories();
                c.AddServices();
                c.AddTransient<Discover>();
                c.AddTransient<ArtistInfo>();
                c.AddTransient<SongInfo>();
                c.AddTransient<NewPlaylist>();
            }).Build();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            host.Start();
            ApplicationConfiguration.Initialize();
            Application.Run(new Homepage());
        }
    }
}