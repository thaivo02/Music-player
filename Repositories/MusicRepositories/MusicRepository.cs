using Muzic.Database;
using Muzic.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzic.Repositories.MusicRepositories
{
    public class MusicRepository : Repository<Music, int>, IMusicRepository
    {
        public MusicRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
