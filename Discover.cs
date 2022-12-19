using Muzic.CommonMethod;
using Muzic.Properties;
using Muzic.Repositories.MusicRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Muzic.Database.Entity;
using Muzic.Repositories.ArtistRepositories;
using NAudio.Wave;

namespace Muzic
{
    public partial class Discover : Form
    {
        private readonly IMusicRepository _musicRepository;
        private readonly IArtistRepository _artistRepository;
        public static List<Music> Musics = new List<Music>();
        public void UpdateLabSong(Guna2ImageButton image, Guna2HtmlLabel name, Guna2HtmlLabel singer, Music music)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discover));
            image.Image = (Image)resources.GetObject(music.Thumbnail)!;
            name.Text = music.MusicName;
            var artist = _artistRepository.GetAll().First(e => e.ArtistId == music.ArtistId);
            singer.Text = artist.ArtistName;
        }
        
        public void UpdatePopSong(Guna2PictureBox image, Guna2HtmlLabel name, Guna2HtmlLabel singer, Music music)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discover));
            image.Image = (Image) resources.GetObject(music.Thumbnail)!;
            name.Text = music.MusicName;
            var artist = _artistRepository.GetAll().First(e => e.ArtistId == music.ArtistId);
            singer.Text = artist.ArtistName;
        }

        public void PlaySong(int i)
        {
            WaveOutEvent wo = new WaveOutEvent();
            AudioFileReader af = new AudioFileReader(Musics[i].URL);
            Homepage.LoadMusic(wo, af);
        }

        public Discover(IMusicRepository musicRepository, IArtistRepository artistRepository)
        {
            _musicRepository = musicRepository;
            _artistRepository = artistRepository;
            InitializeComponent();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discover));
            Musics = _musicRepository.GetAll().ToList();
            Musics.Shuffle();
            UpdateLabSong(picSong1, labSong1_name, labSong1_singer, Musics[0]);                       
            UpdateLabSong(picSong2, labSong2_name, labSong2_singer, Musics[1]);                       
            UpdateLabSong(picSong3, labSong3_name, labSong3_singer, Musics[2]);                       
            UpdateLabSong(picSong4, labSong4_name, labSong4_singer, Musics[3]);                       
            UpdateLabSong(picSong5, labSong5_name, labSong5_singer, Musics[4]);                       
            UpdateLabSong(picSong6, labSong6_name, labSong6_singer, Musics[5]);    
            
            UpdatePopSong(picPop1, labPop1_name, labPop1_singer, Musics[5]);
            UpdatePopSong(picPop2, labPop2_name, labPop2_singer, Musics[6]);
            UpdatePopSong(picPop3, labPop3_name, labPop3_singer, Musics[7]);
            UpdatePopSong(picPop4, labPop4_name, labPop4_singer, Musics[8]);
            UpdatePopSong(picPop5, labPop5_name, labPop5_singer, Musics[9]);
            UpdatePopSong(picPop6, labPop6_name, labPop6_singer, Musics[10]);
        }

        public void Init(DockStyle dock, bool topLevel, bool topMost)
        {
            Dock = dock;
            TopLevel = topLevel;
            TopMost = topMost;
        }

        private void btnPop1_play_Click(object sender, EventArgs e)
        {
            PlaySong(6);
        }

        private void btnPop2_play_Click(object sender, EventArgs e)
        {
            PlaySong(7);
        }

        private void btnPop3_play_Click(object sender, EventArgs e)
        {
            PlaySong(8);
        }

        private void btnPop4_play_Click(object sender, EventArgs e)
        {
            PlaySong(9);
        }

        private void btnPop5_play_Click(object sender, EventArgs e)
        {
            PlaySong(10);
        }

        private void btnPop6_play_Click(object sender, EventArgs e)
        {
            PlaySong(11);
        }

        private void picSong1_Click(object sender, EventArgs e)
        {
            PlaySong(0);
        }

        private void picSong2_Click(object sender, EventArgs e)
        {
            PlaySong(1);
        }

        private void picSong3_Click(object sender, EventArgs e)
        {
            PlaySong(2);
        }

        private void picSong4_Click(object sender, EventArgs e)
        {
            PlaySong(3);
        }

        private void picSong5_Click(object sender, EventArgs e)
        {
            PlaySong(4);
        }

        private void picSong6_Click(object sender, EventArgs e)
        {
            PlaySong(5);
        }

        private void btnSongInfo(object sender, EventArgs e)
        {
            SongInfo frm = new SongInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
