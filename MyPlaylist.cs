using Guna.UI2.WinForms;
using Muzic.Database.Entity;
using Muzic.Repositories.MusicRepositories;
using Muzic.Repositories.PlaylistMusicRepositories;
using Muzic.Repositories.PlaylistRepositories;

namespace Muzic
{
    public partial class MyPlaylist : Form
    {
        private readonly IPlaylistRepository _playlistRepository;
        private readonly IPlaylistMusicRepository _playlistMusicRepository;
        public static List<Playlist> Playlist = new List<Playlist>();
        public static List<PlaylistMusic> PlaylistMusic = new List<PlaylistMusic>();
        public MyPlaylist(IPlaylistRepository playlistRepository, IPlaylistMusicRepository playlistMusicRepository)
        {
            _playlistRepository = playlistRepository;
            _playlistMusicRepository = playlistMusicRepository;
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
            // Lay music
            var musicsFromPlaylist = new List<Music>(Discover.Musics);
            // so 1 thay bang Id lay ra
            var playlist = _playlistMusicRepository.GetAll().Where(e => e.PlaylistId == 2);
            musicsFromPlaylist.Select(e => playlist.Any(u => u.MusicId == e.MusicId));
            Discover.Musics = new List<Music>(musicsFromPlaylist);
        }
    }
}
