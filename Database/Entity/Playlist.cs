using System.ComponentModel.DataAnnotations;

namespace Muzic.Database.Entity
{
    public class Playlist : AggressiveRoot<int>
    {
        [Key]
        public int PlaylistId { get; set; }
        public string PlaylistName { get; set; }
    }
}