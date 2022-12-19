using System.ComponentModel.DataAnnotations;

namespace Muzic.Database.Entity
{
    public class Artist : AggressiveRoot<int>
    {
        [Key]
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
    }
}