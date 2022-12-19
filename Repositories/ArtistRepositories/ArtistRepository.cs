using Muzic.Database;
using Muzic.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzic.Repositories.ArtistRepositories
{
    public class ArtistRepository : Repository<Artist, int>, IArtistRepository
    {
        public ArtistRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
