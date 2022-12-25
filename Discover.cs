using Guna.UI2.WinForms;
using Muzic.CommonMethod;
using Muzic.Database.Entity;
using Muzic.Repositories.ArtistRepositories;
using Muzic.Repositories.MusicRepositories;
using System.Data;
using System.Net;

namespace Muzic
{
    public partial class Discover : Form
    {
        private readonly IMusicRepository _musicRepository;
        private readonly IArtistRepository _artistRepository;
        public static List<Music> Musics = new List<Music>();
        public static List<Music> MusicsTemp = new List<Music>();
        public static List<Artist> Artists = new List<Artist>();
        public void UpdateLabSong(Guna2ImageButton image, Guna2HtmlLabel name, Guna2HtmlLabel singer, Music music)
        {
            var request = WebRequest.Create(music.Thumbnail);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                image.Image = Image.FromStream(stream);
            }
            name.Text = music.MusicName;
            var artist = _artistRepository.GetAll().First(e => e.ArtistId == music.ArtistId);
            singer.Text = artist.ArtistName;
        }

        public void UpdatePopSong(Guna2PictureBox image, Guna2HtmlLabel name, Guna2HtmlLabel singer, Music music)
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

        public void PlaySong(int i)
        {
            Homepage.labPlaying_name.Text = Musics[i].MusicName;
            var artist = _artistRepository.GetAll().First(e => e.ArtistId == Musics[i].ArtistId);
            Homepage.labPlaying_singer.Text = artist.ArtistName;
            var request1 = WebRequest.Create(Musics[i].Thumbnail);
            using (var response = request1.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Homepage.image = (Bitmap)Image.FromStream(stream);
            }

            Homepage.CurrentIndex = i;
            Homepage.LoadMusic(Musics[i].URL + ".mp3");
        }

        public Discover(IMusicRepository musicRepository, IArtistRepository artistRepository)
        {
            _musicRepository = musicRepository;
            _artistRepository = artistRepository;
            Artists = _artistRepository.GetAll().ToList();
            InitializeComponent();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discover));
            Musics = _musicRepository.GetAll().ToList();
            Musics.Shuffle();

            MusicsTemp = new List<Music>(Musics);
            
            var i = 0;
            Discover.Musics.ForEach(e =>
            {
                if (e.MusicId == 16)
                {
                    Homepage.CurrentIndex = i;
                    return;
                }

                i += 1;
            });
            UpdateLabSong(picSong1, labSong1_name, labSong1_singer, Musics[0]);
            UpdateLabSong(picSong2, labSong2_name, labSong2_singer, Musics[1]);
            UpdateLabSong(picSong3, labSong3_name, labSong3_singer, Musics[2]);
            UpdateLabSong(picSong4, labSong4_name, labSong4_singer, Musics[3]);
            UpdateLabSong(picSong5, labSong5_name, labSong5_singer, Musics[4]);
            UpdateLabSong(picSong6, labSong6_name, labSong6_singer, Musics[5]);

            UpdatePopSong(picPop1, labPop1_name, labPop1_singer, Musics[6]);
            UpdatePopSong(picPop2, labPop2_name, labPop2_singer, Musics[7]);
            UpdatePopSong(picPop3, labPop3_name, labPop3_singer, Musics[8]);
            UpdatePopSong(picPop4, labPop4_name, labPop4_singer, Musics[9]);
            UpdatePopSong(picPop5, labPop5_name, labPop5_singer, Musics[10]);
            UpdatePopSong(picPop6, labPop6_name, labPop6_singer, Musics[11]);
        }

        public void Init(DockStyle dock, bool topLevel, bool topMost)
        {
            Dock = dock;
            TopLevel = topLevel;
            TopMost = topMost;
        }

        private void btnPop1_play_Click(object sender, EventArgs e)
        {
            Musics = new List<Music>(MusicsTemp);
            PlaySong(6);
        }

        private void btnPop2_play_Click(object sender, EventArgs e)
        {
            Musics = new List<Music>(MusicsTemp);
            PlaySong(7);
        }

        private void btnPop3_play_Click(object sender, EventArgs e)
        {
            Musics = new List<Music>(MusicsTemp);
            PlaySong(8);
        }

        private void btnPop4_play_Click(object sender, EventArgs e)
        {
            Musics = new List<Music>(MusicsTemp);
            PlaySong(9);
        }

        private void btnPop5_play_Click(object sender, EventArgs e)
        {
            Musics = new List<Music>(MusicsTemp);
            PlaySong(10);
        }

        private void btnPop6_play_Click(object sender, EventArgs e)
        {
            Musics = new List<Music>(MusicsTemp);
            PlaySong(11);
        }

        private void picSong1_Click(object sender, EventArgs e)
        {
            Musics = new List<Music>(MusicsTemp);
            PlaySong(0);
        }

        private void picSong2_Click(object sender, EventArgs e)
        {
            Musics = new List<Music>(MusicsTemp);
            PlaySong(1);
        }

        private void picSong3_Click(object sender, EventArgs e)
        {
            Musics = new List<Music>(MusicsTemp);
            PlaySong(2);
        }

        private void picSong4_Click(object sender, EventArgs e)
        {
            Musics = new List<Music>(MusicsTemp);
            PlaySong(3);
        }

        private void picSong5_Click(object sender, EventArgs e)
        {
            Musics = new List<Music>(MusicsTemp);
            PlaySong(4);
        }

        private void picSong6_Click(object sender, EventArgs e)
        {
            Musics = new List<Music>(MusicsTemp);
            PlaySong(5);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                listBox1.Items.Clear();
                listBox1.Visible = true;
                foreach (string str in Artists.Select(e => e.ArtistName))
                {
                    if (str.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listBox1.Items.Add(str + " - Artist");
                    }
                }
                foreach (string str in Musics.Select(e => e.MusicName))
                {
                    if (str.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listBox1.Items.Add(str + " - Song");
                    }
                } 
            }
            else
            {
                listBox1.Visible = false;
                listBox1.Items.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textFull = listBox1.GetItemText(listBox1.SelectedItem);
            string text = textFull.Split(" - ")[0];
            string artist = textFull.Split(" - ")[1];
            var index = 0;
            var temp = 0;
            Musics.ForEach(e =>
            {
                if (e.MusicName == text && artist != "Artist")
                {
                    temp = index;
                }
                index += 1;
            });
            if (artist != "Artist") PlaySong(temp);
        }
    }
}
