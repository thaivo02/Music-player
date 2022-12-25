using Guna.UI2.WinForms;
using Muzic.Database.Entity;
using Muzic.Repositories.ArtistRepositories;
using Muzic.Repositories.MusicRepositories;
using Muzic.Repositories.PlaylistMusicRepositories;
using Muzic.Repositories.PlaylistRepositories;
using System.Net;

namespace Muzic
{
    public partial class MyPlaylist : Form
    {
        private readonly IPlaylistRepository _playlistRepository;
        private readonly IPlaylistMusicRepository _playlistMusicRepository;
        private readonly IArtistRepository _artistRepository;
        public static List<Playlist> Playlist = new List<Playlist>();
        public static List<PlaylistMusic> PlaylistMusic = new List<PlaylistMusic>();
        public MyPlaylist(IPlaylistRepository playlistRepository, IPlaylistMusicRepository playlistMusicRepository, IArtistRepository artistRepository)
        {
            _playlistRepository = playlistRepository;
            _playlistMusicRepository = playlistMusicRepository;
            _artistRepository = artistRepository;

            InitializeComponent();
            Playlist = _playlistRepository.GetAll().ToList();
            PlaylistMusic = _playlistMusicRepository.GetAll().ToList();
            UpdatePlaylist();   
        }

        public void Init(DockStyle dock, bool topLevel, bool topMost)
        {
            Dock = dock;
            TopLevel = topLevel;
            TopMost = topMost;
        }

        private void UpdatePlaylist()
        {
            for (int i = 1; i <= Playlist.Count; i++)
            {
                if (i >= 2)
                {
                    string panel = "panPlaylist" + i.ToString();
                    this.Controls.Find(panel, true)[0].Visible = true;
                }
                string name = "labPlaylist_name" + i.ToString();
                string amount = "labPlaylist_amount" + i.ToString();
                this.Controls.Find(name, true)[0].Text = "Playlist name: " + Playlist.First(e => e.PlaylistId == i).PlaylistName;
                this.Controls.Find(amount, true)[0].Text = Playlist.First(e => e.PlaylistId == i).PlaylistName + ": " +
                                                         PlaylistMusic.Count(e => e.PlaylistId == i).ToString() + " songs in playlist";
            }
        }

        public void clickPlaylist(object sender, EventArgs e)
        {
            Guna2ImageButton pressed = (Guna2ImageButton)sender;
            int index = 1;
            if (pressed.Name.Length > 12)
                index = 10 + (int)pressed.Name[12] - 48;
            else index = (int)pressed.Name[11] - 48;
            var musicsFromPlaylist = new List<Music>(Discover.Musics);
            var playlist = _playlistMusicRepository.GetAll().Where(e => e.PlaylistId == index);
            musicsFromPlaylist = musicsFromPlaylist.Where(e => playlist.Any(u => u.MusicId == e.MusicId)).ToList();
            //musicsFromPlaylist.Select(e => playlist.Any(u => u.MusicId == e.MusicId));
            Discover.Musics = musicsFromPlaylist;
            PlaySong(0);
        }

        public void PlaySong(int i)
        {
            Homepage.labPlaying_name.Text = Discover.Musics[i].MusicName;
            var artist = _artistRepository.GetAll().First(e => e.ArtistId == Discover.Musics[i].ArtistId);
            Homepage.labPlaying_singer.Text = artist.ArtistName;
            var request1 = WebRequest.Create(Discover.Musics[i].Thumbnail);
            using (var response = request1.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Homepage.image = (Bitmap)Image.FromStream(stream);
            }

            Homepage.CurrentIndex = i;
            Homepage.LoadMusic(Discover.Musics[i].URL + ".mp3");
        }
    }
}
