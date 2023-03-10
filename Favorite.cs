using Microsoft.Extensions.DependencyInjection;
using Muzic.Database.Entity;
using Muzic.Repositories.ArtistRepositories;
using Muzic.Repositories.MusicRepositories;
using System.Data;
using System.Net;

namespace Muzic
{
    public partial class Favorite : Form
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IMusicRepository _musicRepository;
        public static List<Music> Musics = new List<Music>();
        public Favorite(IMusicRepository musicRepository, IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
            _musicRepository = musicRepository;
            InitializeComponent();
            Musics = _musicRepository.GetAll().ToList();
            var i = 0;
            Musics.ForEach(e =>
            {
                string name = "";
                if (e.IsFavorite == true)
                {
                    name = Discover.Artists.First(p => p.ArtistId == e.ArtistId).ArtistName;
                    dataGrid.Rows.Add(e.MusicName, name);
                }
               i += 1;
            });
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.CurrentCell.OwningColumn.Name == "colSong")
            {
                List<Music> listFavorite = new List<Music>();
                listFavorite = Musics.FindAll(e => e.MusicName == (string)dataGrid.CurrentCell.FormattedValue).ToList();
                Homepage.labPlaying_name.Text = listFavorite[0].MusicName;
                var artist = _artistRepository.GetAll().First(e => e.ArtistId == listFavorite[0].ArtistId);
                Homepage.labPlaying_singer.Text = artist.ArtistName;
                var request1 = WebRequest.Create(listFavorite[0].Thumbnail);
                using (var response = request1.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    Homepage.image = (Bitmap)Image.FromStream(stream);
                }
                Musics.First(e => e.MusicName == listFavorite[0].MusicName).Frequency += 1;
                _musicRepository.SaveChanges();

                Homepage.CurrentIndex = Discover.Musics.FindIndex(e => e.MusicId == listFavorite[0].MusicId);
                Homepage.LoadMusic(listFavorite[0].URL + ".mp3");

            }
        }
    }
}
