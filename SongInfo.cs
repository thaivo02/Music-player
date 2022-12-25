using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Muzic.Database.Entity;
using Muzic.Repositories.MusicRepositories;
using Muzic.Repositories.PlaylistMusicRepositories;
using Muzic.Repositories.PlaylistRepositories;

namespace Muzic
{
    public partial class SongInfo : Form
    {
        private readonly IPlaylistRepository _playlistRepository;
        private readonly IMusicRepository _musicRepository;
        private readonly IPlaylistMusicRepository _playlistMusicRepository;
        public static List<Playlist> Playlist = new List<Playlist>();
        public static List<PlaylistMusic> PlaylistMusic = new List<PlaylistMusic>();
        private string playlistName = string.Empty;
        public SongInfo(IMusicRepository musicRepository, IPlaylistMusicRepository playlistMusicRepository, IPlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
            _playlistMusicRepository = playlistMusicRepository;
            _musicRepository = musicRepository;
            InitializeComponent();
            Playlist =  _playlistRepository.GetAll().ToList();
            PlaylistMusic = _playlistMusicRepository.GetAll().ToList();

            var music = Discover.Musics[Homepage.CurrentIndex];
            string text = System.IO.File.ReadAllText(Discover.Musics[Homepage.CurrentIndex].Lyric+".txt");
            labLyrics.Text = text;
            this.guna2HtmlLabel1.Text = music.MusicName;
            this.guna2HtmlLabel6.Text = Discover.Artists.First(e => e.ArtistId == music.ArtistId).ArtistName;
            var request1 = WebRequest.Create(music.Thumbnail);
            using (var response = request1.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                this.guna2ImageButton1.Image = (Bitmap) Image.FromStream(stream);
            }

            this.txtCmt1.Text = music.Comment;
            initCombobox();
        }

        public void Init()
        {
            Dock = DockStyle.Fill;
            TopLevel = false;
            TopMost = true;
        }

        private void initCombobox()
        {
            List<string> PlaylistName = new List<string>();
            for (int i = 0; i < Playlist.Count; i++)
                PlaylistName.Add(Playlist[i].PlaylistName);
            this.comboPlaylist.DataSource = PlaylistName;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var comment = this.txtComment.Text;
            if (comment != null)
            {
                var music = Discover.Musics[Homepage.CurrentIndex];
                music.Comment = comment;
                _musicRepository.Update(music);
                _musicRepository.SaveChanges();
                this.txtCmt1.Text = comment;
                txtComment.Text = "";
            }
        }

        private void btnAddtoPlaylist_Click(object sender, EventArgs e)
        {
            int playlistIndex = Playlist.Find(e => e.PlaylistName == playlistName).PlaylistId; 
            if (PlaylistMusic.Exists(e => e.MusicId == Discover.Musics[Homepage.CurrentIndex].MusicId && e.PlaylistId == playlistIndex) == false)
            {
                PlaylistMusic addPlaylist = new PlaylistMusic()
                {
                    MusicId = Discover.Musics[Homepage.CurrentIndex].MusicId,
                    PlaylistId = playlistIndex
                };
                _playlistMusicRepository.Add(addPlaylist);
                _playlistMusicRepository.SaveChanges();
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            var location = Discover.Musics[Homepage.CurrentIndex].URL + ".mp3";
            var destination = folderBrowserDialog1.SelectedPath.ToString();
            var name = Discover.Musics[Homepage.CurrentIndex].MusicName + ".mp3";
            File.Copy(location, destination + "\\" + name);
        }

        private void comboPlaylist_SelectedValueChanged(object sender, EventArgs e)
        {
            playlistName = comboPlaylist.Text;
        }
    }
}
