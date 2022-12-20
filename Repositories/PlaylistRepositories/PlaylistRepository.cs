using Muzic.Database;
using Muzic.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzic.Repositories.PlaylistRepositories
{
    public class PlaylistRepository : Repository<Playlist, int>, IPlaylistRepository
    {
        public PlaylistRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
