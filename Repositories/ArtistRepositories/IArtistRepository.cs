using Muzic.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzic.Repositories.ArtistRepositories
{
    public interface IArtistRepository : IRepository<Artist, int>
    {
    }
}
