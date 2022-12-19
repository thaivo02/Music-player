using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Muzic.Database.Entity;

namespace Muzic.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Artist> Accounts { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<PlaylistMusic> PlaylistMusics { get; set; }
        public DbSet<Playlist> Playlists { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}