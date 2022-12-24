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
        public MyPlaylist(IPlaylistRepository playlistRepository, IPlaylistMusicRepository playlistMusicRepository)
        {
            _playlistRepository = playlistRepository;
            _playlistMusicRepository = playlistMusicRepository;
            InitializeComponent();
        }

        public void Init(DockStyle dock, bool topLevel, bool topMost)
        {
            Dock = dock;
            TopLevel = topLevel;
            TopMost = topMost;
        }

        public void clickPlaylist()
        {
            // Lay music
            var musicsFromPlaylist = new List<Music>(Discover.Musics);
            // so 1 thay bang Id lay ra
            var playlist = _playlistMusicRepository.GetAll().Where(e => e.PlaylistId == 1);
            musicsFromPlaylist.Select(e => playlist.Any(u => u.MusicId == e.MusicId));
            Discover.Musics = new List<Music>(musicsFromPlaylist);
        }

    }
}
