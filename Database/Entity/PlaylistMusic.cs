using System.ComponentModel.DataAnnotations;

namespace Muzic.Database.Entity
{
    public class PlaylistMusic : AggressiveRoot<int>
    {
        [Key]
        public int Id { get; set; }
        public int PlaylistId { get; set; }
        public int MusicId { get; set; }
    }
}