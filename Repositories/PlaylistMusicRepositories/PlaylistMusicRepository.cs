using Muzic.Database;
using Muzic.Database.Entity;

namespace Muzic.Repositories.PlaylistMusicRepositories
{
    public class PlaylistMusicRepository :  Repository<PlaylistMusic, int>, IPlaylistMusicRepository
    {
        public PlaylistMusicRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}