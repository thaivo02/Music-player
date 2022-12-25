using Guna.UI2.WinForms;
using Muzic.Database.Entity;
using Muzic.Repositories.ArtistRepositories;
using Muzic.Repositories.MusicRepositories;
using System.Net;
using System.Windows.Forms;

namespace Muzic
{
    public partial class Genre : Form
    {
        private readonly IMusicRepository _musicRepository;
        private readonly IArtistRepository _artistRepository;
        public static List<Music> Musics = new List<Music>();
        private static List<Music> listCountry = new List<Music>();
        private static List<Music> listDisco = new List<Music>();
        private static List<Music> listIndie = new List<Music>();
        private static List<Music> listRap = new List<Music>();
        private static List<Music> listRaB = new List<Music>();
        private static List<Music> listEDM = new List<Music>();
        private static List<Music> listPop = new List<Music>();
        public Genre(IMusicRepository musicRepository, IArtistRepository artistRepository)
        {
            _musicRepository = musicRepository;
            _artistRepository = artistRepository;
            InitializeComponent();
            Musics = _musicRepository.GetAll().ToList();
            GetGenres();
            UpdateSong(picCountry, labCountry_song, labCoutry_singer, listCountry[0]);

            UpdateSong(picDisco, labDisco_song, labDisco_singer, listDisco[0]);

            UpdateSong(picIndie1, labIndie1_song, labIndie1_song, listIndie[0]);
            UpdateSong(picIndie2, labIndie2_song, labIndie2_song, listIndie[1]);

            UpdateSong(picRap1, labRap1_song, labRap1_singer, listRap[0]);
            UpdateSong(picRap2, labRap2_song, labRap2_singer, listRap[1]);
            UpdateSong(picRap3, labRap3_song, labRap3_singer, listRap[2]);
            
            UpdateSong(picRaB1, labRaB1_song, labRaB2_singer, listRaB[0]);
            UpdateSong(picRaB2, labRaB2_song, labRaB2_singer, listRaB[1]);
            UpdateSong(picRaB3, labRaB1_song, labRaB3_singer, listRaB[2]);

            UpdateSong(picEDM1, labEDM1_song, labEDM1_singer, listEDM[0]);
            UpdateSong(picEDM2, labEDM2_song, labEDM2_singer, listEDM[1]);
            UpdateSong(picEDM3, labEDM3_song, labEDM3_singer, listEDM[2]);
            UpdateSong(picEDM4, labEDM4_song, labEDM4_singer, listEDM[3]);
            UpdateSong(picEDM5, labEDM5_song, labEDM5_singer, listEDM[4]);
            UpdateSong(picEDM6, labEDM6_song, labEDM6_singer, listEDM[5]);
            UpdateSong(picEDM7, labEDM7_song, labEDM7_singer, listEDM[6]);
            UpdateSong(picEDM8, labEDM8_song, labEDM8_singer, listEDM[7]);
            UpdateSong(picEDM9, labEDM9_song, labEDM9_singer, listEDM[8]);
            UpdateSong(picEDM10, labEDM10_song, labEDM10_singer, listEDM[9]);

            UpdateSong(picPop1, labPop1_song, labPop1_singer, listPop[0]);
            UpdateSong(picPop2, labPop2_song, labPop2_singer, listPop[1]);
            UpdateSong(picPop3, labPop3_song, labPop3_singer, listPop[2]);
            UpdateSong(picPop4, labPop4_song, labPop4_singer, listPop[3]);
            UpdateSong(picPop5, labPop5_song, labPop5_singer, listPop[4]);
            UpdateSong(picPop6, labPop6_song, labPop6_singer, listPop[5]);
            UpdateSong(picPop7, labPop7_song, labPop7_singer, listPop[6]);
            UpdateSong(picPop8, labPop8_song, labPop8_singer, listPop[7]);
            UpdateSong(picPop9, labPop9_song, labPop9_singer, listPop[8]);
            UpdateSong(picPop10, labPop10_song, labPop10_singer, listPop[9]);
            UpdateSong(picPop11, labPop11_song, labPop11_singer, listPop[10]);
        }
        public void Init(DockStyle dock, bool topLevel, bool topMost)
        {
            Dock = dock;
            TopLevel = topLevel;
            TopMost = topMost;
        }

        private void GetGenres()
        {
            listCountry = Discover.Musics.FindAll(e => e.Genre.Contains("Country")).ToList();
            listDisco = Discover.Musics.FindAll(e => e.Genre.Contains("Disco")).ToList();
            listIndie = Discover.Musics.FindAll(e => e.Genre.Contains("Indie")).ToList();
            listRap = Discover.Musics.FindAll(e => e.Genre.Contains("Rap")).ToList();
            listRaB = Discover.Musics.FindAll(e => e.Genre.Contains("Soul")).ToList();
            listEDM = Discover.Musics.FindAll(e => e.Genre.Contains("Dance") || e.Genre.Contains("House")).ToList();
            listPop = Discover.Musics.FindAll(e => e.Genre.Contains("Pop") || e.Genre.Contains("pop")).ToList();
        }

        private void UpdateSong(Guna2PictureBox image, Guna2HtmlLabel name, Guna2HtmlLabel singer, Music music)
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
        }

        private void btnCountry_play_Click(object sender, EventArgs e)
        {
            Homepage.labPlaying_name.Text = listCountry[0].MusicName;
            var artist = _artistRepository.GetAll().First(e => e.ArtistId == listCountry[0].ArtistId);
            Homepage.labPlaying_singer.Text = artist.ArtistName;
            var request1 = WebRequest.Create(listCountry[0].Thumbnail);
            using (var response = request1.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Homepage.image = (Bitmap)Image.FromStream(stream);
            }
            Musics.First(e => e.MusicName == listCountry[0].MusicName).Frequency += 1;
            _musicRepository.SaveChanges();

            Homepage.CurrentIndex = 0;
            Homepage.LoadMusic(listCountry[0].URL + ".mp3");
        }

        private void btnDisco_play_Click(object sender, EventArgs e)
        {
            Homepage.labPlaying_name.Text = listDisco[0].MusicName;
            var artist = _artistRepository.GetAll().First(e => e.ArtistId == listDisco[0].ArtistId);
            Homepage.labPlaying_singer.Text = artist.ArtistName;
            var request1 = WebRequest.Create(listDisco[0].Thumbnail);
            using (var response = request1.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Homepage.image = (Bitmap)Image.FromStream(stream);
            }
            Musics.First(e => e.MusicName == listDisco[0].MusicName).Frequency += 1;
            _musicRepository.SaveChanges();

            Homepage.CurrentIndex = 0;
            Homepage.LoadMusic(listDisco[0].URL + ".mp3");
        }
    }
}
