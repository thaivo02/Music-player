using Muzic.Repositories.MusicRepositories;
using Muzic.Repositories.PlaylistRepositories;

namespace Muzic
{
    public partial class MyPlaylist : Form
    {
        private readonly IPlaylistRepository _playlistRepository;
        public MyPlaylist(IPlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
            InitializeComponent();

        }

        public void Init(DockStyle dock, bool topLevel, bool topMost)
        {
            Dock = dock;
            TopLevel = topLevel;
            TopMost = topMost;
        }
    }
}
