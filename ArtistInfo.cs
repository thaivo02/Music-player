using Guna.UI2.WinForms;
using Muzic.Database.Entity;
using Muzic.Repositories.ArtistRepositories;
using Muzic.Repositories.MusicRepositories;
using System.Net;

namespace Muzic
{
    public partial class ArtistInfo : Form
    {
        private readonly IMusicRepository _musicRepository;
        private readonly IArtistRepository _artistRepository;
        private static List<Music> Songs = new List<Music>();
        public ArtistInfo(IMusicRepository musicRepository, IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
            _musicRepository = musicRepository;
            InitializeComponent();
            picArtist.Image = HotArtists.button.Image;
            labArtist.Text = Discover.Artists.First(e => e.ArtistId == HotArtists.index).ArtistName;
            Songs = Discover.Musics.FindAll(e => e.ArtistId == HotArtists.index).ToList();

            UpdateSong(picSong1, labSong1, labSinger1, btnFav1, Songs[0]);
            if (Songs.Count >= 2)
            {
                Song2.Visible = true;
                UpdateSong(picSong2, labSong2, labSinger2, btnFav2, Songs[1]);
            }
            if (Songs.Count == 3)
            {
                Song3.Visible = true;
                UpdateSong(picSong3, labSong3, labSinger3, btnFav3, Songs[2]);
            }
        }
        public void Init(DockStyle dock, bool topLevel, bool topMost)
        {
            Dock = dock;
            TopLevel = topLevel;
            TopMost = topMost;
        }


        public void UpdateSong(Guna2PictureBox image, Guna2HtmlLabel name, Guna2HtmlLabel singer, Guna2ImageButton favorite, Music music)
        {
            var request = WebRequest.Create(music.Thumbnail);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                image.Image = Bitmap.FromStream(stream);
            }
            name.Text = music.MusicName;
            var artist = _artistRepository.GetAll().First(e => e.ArtistId == music.ArtistId);
            singer.Text = artist.ArtistName;
            favorite.Checked = music.IsFavorite;
        }

        public void PlaySong(int i)
        {
            Homepage.labPlaying_name.Text = Songs[i].MusicName;
            var artist = _artistRepository.GetAll().First(e => e.ArtistId == Songs[i].ArtistId);
            Homepage.labPlaying_singer.Text = artist.ArtistName;
            var request1 = WebRequest.Create(Songs[i].Thumbnail);
            using (var response = request1.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Homepage.image = (Bitmap)Image.FromStream(stream);
            }

            Homepage.CurrentIndex = Discover.Musics.FindIndex(e => e.MusicId == Songs[i].MusicId);
            Homepage.LoadMusic(Songs[i].URL + ".mp3");
        }

        private void btnPlay1_Click(object sender, EventArgs e)
        {
            PlaySong(0);
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            PlaySong(1);
        }

        private void btnPlay3_Click(object sender, EventArgs e)
        {
            PlaySong(2);
        }

        private void btnFav3_Click(object sender, EventArgs e)
        {
            btnFav3.Checked = !btnFav3.Checked;
            Favorite(2);
        }

        private void btnFav2_Click(object sender, EventArgs e)
        {
            btnFav2.Checked = !btnFav2.Checked;
            Favorite(1);
        }

        private void btnFav1_Click(object sender, EventArgs e)
        {
            btnFav1.Checked = !btnFav1.Checked;
            Favorite(0);
        }

        private void Favorite(int i)
        {
            Songs[i].IsFavorite = !Songs[i].IsFavorite;
            _musicRepository.SaveChanges();
        }
    }
}